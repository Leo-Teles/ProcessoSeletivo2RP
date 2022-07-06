using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProcessoSeletivo_2RP_CodeFirst.Domanis
{

    [Table("Usuarios")]
    public class Usuarios
    {
        internal int IdTiposUsuario;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity) ]
        public int IdUsuario { get; set; }

        [Column(TypeName ="varchar(150)")]
        [Required(ErrorMessage = "O e-mail é obrigatório.")]
        public string Email { get; set; }

        [Column(TypeName ="varchar(30)")]
        [Required(ErrorMessage = "A senha é obrigatória.")]
        [StringLength(30, MinimumLength = 5, ErrorMessage ="A senha do usuário deve conter de 5 a 30 caracteres.")]
        public string Senha { get; set; }

        [Column(TypeName ="varchar(50)")]
        [Required(ErrorMessage ="O nome de usuário é obrigatória.")]
        public string Nome { get; set; }

        [Column]
        [Required(ErrorMessage ="È obrigatório passar os status do usuário.")]
        public bool Status { get; set; }

        [ForeignKey("IdTipoUsuario")]
        public TiposUsuario tipoUsuario { get; set; }
        public object IdTipoUsuarioNavigation { get; internal set; }
    }
}
