using JRSEstudoMvcWeb_Dominio.Usuarios.Dtos;

namespace JRSEstudoMvcWeb_Dominio.Usuarios
{
    public interface IRepUsuario 
    {
        Task<IEnumerable<Usuario>> GetAll();
        Task<Usuario> GetById(int id);
        Task<Usuario> Created(Usuario usuario);
        Task Update(Usuario usuario);
        Task Delete(int id);
        List<Usuario> GetFilter(UsuarioFiltroDto filtros);
    }
}
