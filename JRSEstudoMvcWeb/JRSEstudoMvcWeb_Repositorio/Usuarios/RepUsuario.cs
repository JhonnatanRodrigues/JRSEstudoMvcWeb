using JRSEstudoMvcWeb_Dominio.Usuarios;
using JRSEstudoMvcWeb_Dominio.Usuarios.Dtos;
using JRSEstudoMvcWeb_Repositorio.Configs;
using Microsoft.EntityFrameworkCore;

namespace JRSEstudoMvcWeb_Repositorio.Usuarios
{
    public class RepUsuario : IRepUsuario
    {
        public readonly ContextoBanco _Db;
        public RepUsuario(ContextoBanco Db)
        {
            _Db = Db;
        }

        public async Task<Usuario> Created(Usuario usuario)
        {
            _Db.Usuario.Add(usuario);
            await _Db.SaveChangesAsync();

            return usuario;
        }

        public async Task Delete(int id)
        {
            var usuarioDelete = _Db.Usuario.FindAsync(id).Result;
            _Db.Usuario.Remove(usuarioDelete);
            await _Db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Usuario>> GetAll()
        {
            return await _Db.Usuario.ToListAsync();
        }

        public async Task<Usuario> GetById(int id)
        {
            return await _Db.Usuario.FindAsync(id);
        }

        public List<Usuario> GetFilter(UsuarioFiltroDto filtros)
        {
            return _Db.Usuario.Where(x => ((!filtros.CodigoUsuario.HasValue) ? !filtros.CodigoUsuario.HasValue : x.IDUSUARIO == filtros.CodigoUsuario) &&
                                              ((filtros.NomeUsuario == null) ? filtros.NomeUsuario == null : x.NOMEUSUARIO == filtros.NomeUsuario) &&
                                              ((filtros.SobrenomeUsuario == null) ? filtros.SobrenomeUsuario == null : x.SOBRENOMEUSUARIO == filtros.SobrenomeUsuario) &&
                                              ((!filtros.IdadeUsuario.HasValue) ? !filtros.IdadeUsuario.HasValue : x.Idade == filtros.IdadeUsuario)).ToList();
        }

        public async Task Update(Usuario usuario)
        {
            _Db.Entry(usuario).State = EntityState.Modified;
            await _Db.SaveChangesAsync();
        }
    }
}
