using JRSEstudoMvcWeb_Aplicacao.Usuarios.Dtos;
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

        public List<Usuario> GetAll()
        {
            var ret = _repUsuario.GetAll().Result.ToList();

            return ret;
        }
        public List<Usuario> GetFilter(UsuarioFiltroDto filtros)
        {
            return _repUsuario.GetFilter(filtros);
        }
        public Usuario Created(Usuario user)
        {
            return _repUsuario.Created(user).Result;
        }
        public HttpResponseMessage Delete(int id)
        {
            _repUsuario.Delete(id);

            return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
        }
        public HttpResponseMessage Update(UsuarioDto userDto)
        {
            var user = _repUsuario.GetById(userDto.IDUSUARIO).Result;

            user.NOMEUSUARIO = userDto.NOMEUSUARIO != null ? userDto.NOMEUSUARIO : user.NOMEUSUARIO;
            user.SOBRENOMEUSUARIO = userDto.SOBRENOMEUSUARIO != null ? userDto.SOBRENOMEUSUARIO : user.SOBRENOMEUSUARIO;
            user.Idade = userDto.Idade.HasValue ? userDto.IDUSUARIO : user.IDUSUARIO;
            user.DataNacimento = (DateTime)(userDto.DataNacimento.HasValue ? userDto.DataNacimento : user.DataNacimento);


            _repUsuario.Update(user);

            return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
        }

    }
}
