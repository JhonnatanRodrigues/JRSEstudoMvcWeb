using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRSEstudoMvcWeb_Aplicacao.Usuarios.Dtos
{
    public class UsuarioDto
    {
        public int IDUSUARIO { get; set; }
        public string NOMEUSUARIO { get; set; }
        public string SOBRENOMEUSUARIO { get; set; }
        public int? Idade { get; set; }
        public DateTime? DataNacimento { get; set; }
    }
}
