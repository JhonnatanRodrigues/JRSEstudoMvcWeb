using JRSEstudoMvcWeb_Dominio.Usuarios;
using JRSEstudoMvcWeb_Repositorio.Configs;
using JRSEstudoMvcWeb_Repositorio.Configs.Usuarios;
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
            var usuarioDelete = await _Db.Usuario.FindAsync(id);
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

        public async Task Update(Usuario usuario)
        {
            _Db.Entry(usuario).State = EntityState.Modified;
            await _Db.SaveChangesAsync();
        }
    }
}
