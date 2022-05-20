using JRSEstudoMvcWeb_Aplicacao.Usuarios;
using JRSEstudoMvcWeb_Dominio.Usuarios;
using JRSEstudoMvcWeb_Dominio.Usuarios.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace JRSEstudoMvcWeb.Controllers.Usuarios
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private IAplicUsuario _aplicUsuario;

        public UsuarioController(IAplicUsuario aplicUsuario)
        {
            _aplicUsuario = aplicUsuario;
        }

        [HttpGet]
        public List<Usuario> ListarUsuarios()
        {
            return _aplicUsuario.ListarUsuarios();
        }

        [HttpPut]
        public List<Usuario> ListarUsuarios([FromBody] UsuarioFiltroDto filtros)
        {
            return _aplicUsuario.BuscarUsuario(filtros);
        }
    }
}
