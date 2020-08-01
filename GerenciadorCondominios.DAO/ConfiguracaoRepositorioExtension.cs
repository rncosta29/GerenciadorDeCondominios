using GerenciadorCondominios.DAO.Interface;
using GerenciadorCondominios.DAO.Interfaces;
using GerenciadorCondominios.DAO.Repositorios;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorCondominios.DAO
{
    public static class ConfiguracaoRepositorioExtension
    {
        public static void ConfigurarRepositorios(this IServiceCollection services)
        {
            services.AddTransient<IUsuarioRepositorio, UsuarioRepositorio>();
            services.AddTransient<IFuncaoRepositorio, FuncaoRepositorio>();
        }
    }
}
