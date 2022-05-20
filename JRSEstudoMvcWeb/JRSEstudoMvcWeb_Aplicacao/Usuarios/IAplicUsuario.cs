using JRSEstudoMvcWeb_Dominio.Usuarios;
using JRSEstudoMvcWeb_Dominio.Usuarios.Dtos;

namespace JRSEstudoMvcWeb_Aplicacao.Usuarios
{
    public interface IAplicUsuario
    {
        List<Usuario> ListarUsuarios();
        List<Usuario> BuscarUsuario(UsuarioFiltroDto filtros);
    }
}
