using JRSEstudoMvcWeb_Aplicacao.Usuarios;
using JRSEstudoMvcWeb_Dominio.Usuarios;
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
        public Usuario Usuarios()
        {
            return _aplicUsuario.buscar();
        }
    }
}
