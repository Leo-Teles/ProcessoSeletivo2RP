using Microsoft.EntityFrameworkCore;
using senai_gufi_webAPI.Domains;

namespace ProcessoSeletivo_2RP.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet <TipoUsuario> TipoUsuarios { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
