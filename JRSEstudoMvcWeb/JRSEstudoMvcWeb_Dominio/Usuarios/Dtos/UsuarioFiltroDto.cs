namespace JRSEstudoMvcWeb_Dominio.Usuarios.Dtos
{
    public class UsuarioFiltroDto
    {
        public int? CodigoUsuario{ get; set; }
        public string NomeUsuario { get; set; }
        public string SobrenomeUsuario { get; set; }
        public int? IdadeUsuario { get; set; }
    }
}
