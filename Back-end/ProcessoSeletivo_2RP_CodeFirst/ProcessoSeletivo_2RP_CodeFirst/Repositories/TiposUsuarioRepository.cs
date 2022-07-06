using ProcessoSeletivo_2RP_CodeFirst.Context;
using ProcessoSeletivo_2RP_CodeFirst.Domanis;
using ProcessoSeletivo_2RP_CodeFirst.Interfaces;
using System.Collections.Generic;
using System.Linq;


namespace ProcessoSeletivo_2RP_CodeFirst.Repositories
{
    public class TiposUsuarioRepository
    {
        
        public class TiposUsuariosRepository : ITipoUsuarioRepository
        {

            ProcessoContext ctx = new ProcessoContext();


            public void Atualizar(int id, TiposUsuario tipoUsuarioAtualizado)
            {

                TiposUsuario tipoUsuarioBuscado = ctx.TiposUsuarios.Find(id);


                if (tipoUsuarioAtualizado.UsuarioLogin != null)
                {
                    
                    tipoUsuarioBuscado.UsuarioLogin = tipoUsuarioAtualizado.UsuarioLogin;
                }

                
                ctx.TiposUsuarios.Update(tipoUsuarioBuscado);

                ctx.SaveChanges();
            }

            
            public TiposUsuario BuscarPorId(int id)
            {
                return ctx.TiposUsuarios.FirstOrDefault(tu => tu.IdTiposUsuario == id);
            }

            
            public void Cadastrar(TiposUsuario novoTipoUsuario)
            {
                ctx.TiposUsuarios.Add(novoTipoUsuario);


                ctx.SaveChanges();
            }


            public void Deletar(int id)
            {

                TiposUsuario tipoUsuarioBuscado = ctx.TiposUsuarios.Find(id);


                ctx.TiposUsuarios.Remove(tipoUsuarioBuscado);


                ctx.SaveChanges();
            }


            public List<TiposUsuario> Listar()
            {

                return ctx.TiposUsuarios.ToList();
            }
        }
    }
}
