using JRSEstudoMvcWeb_Dominio.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRSEstudoMvcWeb_Aplicacao.Usuarios
{
    public class AplicUsuario : IAplicUsuario
    {
        private readonly IRepUsuario _repUsuario;

        public AplicUsuario(IRepUsuario repUsuario)
        {
            _repUsuario = repUsuario;
        }

        public Usuario buscar()
        {
            var tag = _repUsuario.GetAll();
            var ret = tag.Result.ToList();

            return ret.FirstOrDefault();
        }
    }
}
