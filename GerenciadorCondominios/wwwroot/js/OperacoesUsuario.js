function AprovarUsuario(usuarioId, nome) {
    const url = "/Usuario/AprovarUsuario";

    $.ajax({
        method: 'POST',
        url: url,
        data: { usuarioId: usuarioId },
        success: function (data) {
            if (data === true) {
                $('#' + usuarioId).removeClass("purple darken-3").addClass("green darken-3").text("Aprovado");
                $('#' + usuarioId).children("a").remove();
                $('#' + usuarioId).append('<a class="btn-floating blue darken-4" href="Usuarios/GerenciarUsuarios?usuarioId=' + usuarioId + '&nome=' + nome + '" asp-controller="Usuarios" asp-action="GerenciadorUsuario" asp-route-usuarioId="' + usuarioId + '" asp-route-nome="' + nome + '"><i class="material-icons">group</i></a>');

                M.toast({
                    html: "Usuário aprovado",
                    classes: "green darken-3"
                });
            }
            else {
                M.toast({
                    html: "Não foi possivel aprovar o usuário"
                });
            }
        }
    });
}

function ReprovarUsuario(usuarioId) {
    const url = "/Usuario/ReprovarUsuario";

    $.ajax({
        method: 'POST',
        url: url,
        data: { usuarioId: usuarioId },
        success: function (data) {
            if (data === true) {
                $('#' + usuarioId).removeClass("purple darken-3").addClass("orange darken-3").text("Reprovado");

                M.toast({
                    html: "Usuário reprovado",
                    classes: "orange darken-3"
                });
            }
            else {
                M.toast({
                    html: "Não foi possivel reprovar o usuário"
                });
            }
        }
    });
}