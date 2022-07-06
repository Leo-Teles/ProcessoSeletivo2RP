using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace senai_gufi_webAPI.Domains
{
    public partial class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }


        [Required(ErrorMessage = "Informe o nome do usuário")]
        public string? NomeUsuario { get; set; }

        [Required(ErrorMessage = "Informe o e-mail")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Informe a senha")]

        [StringLength(100, MinimumLength = 5, ErrorMessage = "A senha deve conter no mínimo 5 caracteres")]
        public string? Senha { get; set; }

        [ForeignKey("TiposUsuarios")]
        [Required(ErrorMessage = "Informe seu usuario")]
        public int? IdTipoUsuario { get; set; }

        [Required(ErrorMessage = "Informe será ativo ou inativo")]

        public bool? status { get; set; }



        public virtual TipoUsuario? IdTipoUsuarioNavigation { get; set; }


    }
}