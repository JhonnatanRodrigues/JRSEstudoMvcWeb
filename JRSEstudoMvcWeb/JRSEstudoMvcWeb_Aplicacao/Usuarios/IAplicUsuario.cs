using JRSEstudoMvcWeb_Aplicacao.Usuarios.Dtos;
using JRSEstudoMvcWeb_Dominio.Usuarios;
using JRSEstudoMvcWeb_Dominio.Usuarios.Dtos;

namespace JRSEstudoMvcWeb_Aplicacao.Usuarios
{
    public interface IAplicUsuario
    {
        List<Usuario> GetAll();
        List<Usuario> GetFilter(UsuarioFiltroDto filtros);
        Usuario Created(Usuario user);
        HttpResponseMessage Delete(int id);
        HttpResponseMessage Update(UsuarioDto userDto);
    }
}
