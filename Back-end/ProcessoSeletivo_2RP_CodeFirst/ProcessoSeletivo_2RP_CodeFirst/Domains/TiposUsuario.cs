using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProcessoSeletivo_2RP_CodeFirst.Domanis
{

    [Table("TiposUsuario")]
    public class TiposUsuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTiposUsuario { get; set; }

        [Column(TypeName ="varchar(150)")]
        [Required(ErrorMessage ="O nome de usário é obrigatório")]
        public string UsuarioLogin { get; set; }


    }
}
