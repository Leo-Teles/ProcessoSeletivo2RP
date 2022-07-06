using Microsoft.EntityFrameworkCore;
using ProcessoSeletivo_2RP_CodeFirst.Domanis;


namespace ProcessoSeletivo_2RP_CodeFirst.Context
{
    public class ProcessoContext : DbContext
    {
        public DbSet<TiposUsuario> TiposUsuarios { get; set; }

        public DbSet<Usuarios> Usuarios { get; set;}

        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-9OFE3O0\\SQLEXPRESS; Database=ProcessoSeletivo_2RP_CodeFirst;Integrated Security=True");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TiposUsuario>().HasData(
                
                new TiposUsuario
                {
                    IdTiposUsuario = 1,
                    UsuarioLogin = "Adiministrador"  
                },

                new TiposUsuario
                {
                    IdTiposUsuario = 2,
                    UsuarioLogin = "Root"
                },
                new TiposUsuario
                {
                    IdTiposUsuario = 3,
                    UsuarioLogin = "Geral"
                }
                );

            modelBuilder.Entity<Usuarios>().HasData(

                new Usuarios
                {
                    IdUsuario = 1,
                    Nome = "Adiministrador",
                    Email = "Admin@email.com",
                    Senha = "Admin",
                    Status = true,
                    IdTiposUsuario = 1


                },
                new Usuarios
                {
                    IdUsuario = 2,
                    Nome = "Root",
                    Email = "Root@email.com",
                    Senha = "Root",
                    Status = true,
                    IdTiposUsuario= 2

                },
                new Usuarios
                {
                    IdUsuario = 3,
                    Nome = "Geral",
                    Email = "Geral@email.com",
                    Senha = "Geral",
                    Status = true,
                    IdTiposUsuario = 3

                }
                );
            base.OnModelCreating(modelBuilder);

        }
    }
}
