using JRSEstudoMvcWeb_Dominio.Usuarios;
using JRSEstudoMvcWeb_Dominio.Usuarios.Dtos;

namespace JRSEstudoMvcWeb_Aplicacao.Usuarios
{
    public class AplicUsuario : IAplicUsuario
    {
        private readonly IRepUsuario _repUsuario;

        public AplicUsuario(IRepUsuario repUsuario)
        {
            _repUsuario = repUsuario;
        }

        public List<Usuario> ListarUsuarios()
        {
            var ret = _repUsuario.GetAll().Result.ToList();

            return ret;
        }

        public List<Usuario> BuscarUsuario(UsuarioFiltroDto filtros)
        {
            return _repUsuario.GetFilter(filtros);
        }
    }
}
