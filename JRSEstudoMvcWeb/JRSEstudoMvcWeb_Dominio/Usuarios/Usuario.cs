using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JRSEstudoMvcWeb_Dominio.Usuarios
{
    [Table("db_estudos_usuarios")]
    public class Usuario
    {
        [Key]
        [Column("idusuario")]
        public int IDUSUARIO { get; set; }

        [Column("nomeusuario")]
        public string NOMEUSUARIO { get; set; }

        [Column("sobrenomeusuario")]
        public string SOBRENOMEUSUARIO { get; set; }

        [Column("idadeusuario")]
        public int Idade { get; set; }
    }
}
