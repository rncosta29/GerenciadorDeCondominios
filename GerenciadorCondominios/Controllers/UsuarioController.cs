﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using GerenciadorCondominios.BLL.Models;
using GerenciadorCondominios.DAO.Interface;
using GerenciadorCondominios.DAO.Interfaces;
using GerenciadorCondominios.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorCondominios.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IFuncaoRepositorio _funcaoRepositorio;

        public UsuarioController(IUsuarioRepositorio usuarioRepositorio, IWebHostEnvironment webHostEnvironment, IFuncaoRepositorio funcaoRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _webHostEnvironment = webHostEnvironment;
            _funcaoRepositorio = funcaoRepositorio;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _usuarioRepositorio.PegarTodos());
        }

        [HttpGet]
        public IActionResult Registro()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Registro(RegistroViewModel model, IFormFile foto)
        {
            if(ModelState.IsValid)
            {
                if(foto != null)
                {
                    string diretorioPasta = Path.Combine(_webHostEnvironment.WebRootPath, "Imagens");
                    string nomeFoto = Guid.NewGuid().ToString() + foto.FileName;

                    using (FileStream fileStream = new FileStream(Path.Combine(diretorioPasta, nomeFoto), FileMode.Create))
                    {
                        await foto.CopyToAsync(fileStream);
                        model.Foto = "~/Imagens/" + nomeFoto;
                    }
                }

                Usuario usuario = new Usuario();
                IdentityResult usuarioCriado;

                if(_usuarioRepositorio.VerificarSeExisteRegistro() == 0)
                {
                    usuario.UserName = model.Nome;
                    usuario.CPF = model.CPF;
                    usuario.Email = model.Email;
                    usuario.PhoneNumber = model.Telefone;
                    usuario.Foto = model.Foto;
                    usuario.PrimeiroAcesso = false;
                    usuario.Status = StatusConta.Aprovado;

                    usuarioCriado = await _usuarioRepositorio.CriarUsuario(usuario, model.Senha);

                    if(usuarioCriado.Succeeded)
                    {
                        await _usuarioRepositorio.IncluirUsuarioEmFuncao(usuario, "Administrador");
                        await _usuarioRepositorio.LogarUsuario(usuario, false);
                        return RedirectToAction("Index", "Usuario");
                    }
                }

                usuario.UserName = model.Nome;
                usuario.CPF = model.CPF;
                usuario.Email = model.Email;
                usuario.PhoneNumber = model.Telefone;
                usuario.Foto = model.Foto;
                usuario.PrimeiroAcesso = true;
                usuario.Status = StatusConta.Analisando;

                usuarioCriado = await _usuarioRepositorio.CriarUsuario(usuario, model.Senha);

                if(usuarioCriado.Succeeded)
                {
                    return View("Analise", usuario.UserName);
                }
                else
                {
                    foreach(IdentityError erro in usuarioCriado.Errors)
                    {
                        ModelState.AddModelError("", erro.Description);
                    }
                    return View(model);
                }
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Login()
        {
            if(User.Identity.IsAuthenticated)
            {
                await _usuarioRepositorio.DeslogarUsuario();
            }
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if(ModelState.IsValid)
            {
                Usuario usuario = await _usuarioRepositorio.PegarUsuarioPeloEMail(model.Email);

                if(usuario != null)
                {
                    if(usuario.Status == StatusConta.Analisando)
                    {
                        return View("Analise", usuario.UserName);
                    }
                    else if(usuario.Status == StatusConta.Reprovado)
                    {
                        return View("Reprovado", usuario.UserName);
                    }
                    else if(usuario.PrimeiroAcesso == true)
                    {
                        return View("RedefinirSenha", usuario);
                    }
                    else
                    {
                        PasswordHasher<Usuario> passwordHasher = new PasswordHasher<Usuario>();
                        if(passwordHasher.VerifyHashedPassword(usuario, usuario.PasswordHash, model.Senha) != PasswordVerificationResult.Failed)
                        {
                            await _usuarioRepositorio.LogarUsuario(usuario, false);
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            ModelState.AddModelError("", "Usuario e/ou senhas inválidas");
                            return View(model);
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Usuario e/ou senhas inválidas");
                    return View(model);
                }
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _usuarioRepositorio.DeslogarUsuario();
            return RedirectToAction("Login");
        }

        public IActionResult Analise(string nome)
        {
            return View(nome);
        }

        public IActionResult Reprovado(string nome)
        {
            return View(nome);
        }

        public async Task<JsonResult> AprovarUsuario(string usuarioId)
        {
            Usuario usuario = await _usuarioRepositorio.PegarPeloId(usuarioId);
            usuario.Status = StatusConta.Aprovado;
            await _usuarioRepositorio.IncluirUsuarioEmFuncao(usuario, "Morador");
            await _usuarioRepositorio.AtualizarUsuario(usuario);

            return Json(true);
        }

        public async Task<JsonResult> ReprovarUsuario(string usuarioId)
        {
            Usuario usuario = await _usuarioRepositorio.PegarPeloId(usuarioId);
            usuario.Status = StatusConta.Reprovado;
            await _usuarioRepositorio.AtualizarUsuario(usuario);

            return Json(true);
        }

        [HttpGet]
        public async Task<IActionResult> GerenciarUsuarios(string usuarioId, string nome)
        {
            if(usuarioId == null)
            {
                return NotFound();
            }
            //Ambas podem ser acessada na view dessa maneira
            TempData["usuarioId"] = usuarioId;
            ViewBag.Nome = nome;

            Usuario usuario = await _usuarioRepositorio.PegarPeloId(usuarioId);

            if(usuario == null)
            {
                return NotFound();
            }

            List<FuncaoUsuarioViewModel> viewModel = new List<FuncaoUsuarioViewModel>();

            foreach(Funcao funcao in await _funcaoRepositorio.PegarTodos())
            {
                FuncaoUsuarioViewModel model = new FuncaoUsuarioViewModel
                {
                    FuncaoId = funcao.Id,
                    Nome = funcao.Name,
                    Descricao = funcao.Descricao
                };

                if(await _usuarioRepositorio.VerificarSeUsuarioEstaEmFuncao(usuario, funcao.Name))
                {
                    model.IsSelecionado = true;
                }
                else
                {
                    model.IsSelecionado = false;
                }
                viewModel.Add(model);
            }
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> GerenciarUsuario(List<FuncaoUsuarioViewModel> model)
        {
            string usuarioId = TempData["usuarioId"].ToString();

            Usuario usuario = await _usuarioRepositorio.PegarPeloId(usuarioId);

            if(usuario == null)
            {
                return NotFound();
            }

            IEnumerable<string> funcoes = await _usuarioRepositorio.PegarFuncoesUsuario(usuario);
            IdentityResult resultado = await _usuarioRepositorio.RemoverFuncoesUsuario(usuario, funcoes);

            if(!resultado.Succeeded)
            {
                ModelState.AddModelError("", "Não foi possivel atualizar as funções do usuário");
                return View("GerenciarUsuario", usuarioId);
            }

            resultado = await _usuarioRepositorio.IncluirUsuarioEmFuncoes(usuario,
                model.Where(x => x.IsSelecionado == true).Select(x => x.Nome));

            if (!resultado.Succeeded)
            {
                ModelState.AddModelError("", "Não foi possivel atualizar as funções do usuário");
                return View("GerenciarUsuario", usuarioId);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
