using JRSEstudoMvcWeb_Aplicacao.Usuarios;
using JRSEstudoMvcWeb_Aplicacao.Usuarios.Dtos;
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
        [Route("Bucar_Todos_os_Usuarios")]
        public List<Usuario> BuscarTodos()
        {
            return _aplicUsuario.GetAll();
        }
        [HttpPut]
        [Route("Bucar Usuarios Filtrados")]
        public List<Usuario> BuscarFiltrados([FromBody] UsuarioFiltroDto filtros)
        {
            return _aplicUsuario.GetFilter(filtros);
        }
        [HttpPost]
        [Route("Inserir Usuario")]
        public Usuario NovoUsuario([FromBody] Usuario user)
        {
            return _aplicUsuario.Created(user);
        }
        [HttpPost]
        [Route("Deletar Usuario")]
        public HttpResponseMessage DeletarUsuario([FromBody] int id)
        {
            return _aplicUsuario.Delete(id);
        }
        [HttpPost]
        [Route("Atualizar Cadastro Usuario")]
        public HttpResponseMessage AtualizarUsuario([FromBody] UsuarioDto usuarioDto)
        {
            return _aplicUsuario.Update(usuarioDto);
        }
    }
}
