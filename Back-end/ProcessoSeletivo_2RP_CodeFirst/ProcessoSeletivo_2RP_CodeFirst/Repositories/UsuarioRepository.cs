using Microsoft.AspNetCore.Http;
using ProcessoSeletivo_2RP_CodeFirst.Context;
using ProcessoSeletivo_2RP_CodeFirst.Domanis;
using ProcessoSeletivo_2RP_CodeFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace ProcessoSeletivo_2RP_CodeFirst.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        ProcessoContext ctx = new ProcessoContext();

        

        public Usuarios Login(string email, string senha)
        {
            return ctx.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }

       
        public void Atualizar(int id, Usuarios usuarioAtualizado)
        {
            Usuarios usuarioBuscado = ctx.Usuarios.Find(id);

            if (usuarioAtualizado.Nome != null)
            {
                usuarioBuscado.Nome = usuarioAtualizado.Nome;
            }

            if (usuarioAtualizado.Email != null)
            {
                usuarioBuscado.Email = usuarioAtualizado.Email;
            }

            if (usuarioAtualizado.Senha != null)
            {
                usuarioBuscado.Senha = usuarioAtualizado.Senha;
            }

            ctx.Usuarios.Update(usuarioBuscado);

            ctx.SaveChanges();
        }

      
        public Usuarios BuscarPorId(int id)
        {
            return ctx.Usuarios
                .Select(u => new Usuarios()
                {
                    IdUsuario = u.IdUsuario,
                    Nome = u.Nome,
                    Email = u.Email,
                    IdTiposUsuario = u.IdTiposUsuario,

                    IdTipoUsuarioNavigation = new TiposUsuario()
                    {
                        IdTiposUsuario = u.IdTipoUsuarioNavigation.IdTiposUsuario,
                        UsuarioLogin = u.IdTipoUsuarioNavigation.UsuarioLogin,
                    }
                })
                .FirstOrDefault(u => u.IdUsuario == id);
        }

        public void Cadastrar(Usuarios novoUsuario)
        {
            ctx.Usuarios.Add(novoUsuario);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Usuarios.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

        public List<Usuarios> Listar()
        {
            return ctx.Usuarios
                .Select(u => new Usuarios()
                {
                    IdUsuario = u.IdUsuario,
                    Nome = u.Nome,
                    Email = u.Email,
                    IdTiposUsuario = u.IdTiposUsuario,

                    IdTipoUsuarioNavigation = new TiposUsuario()
                    {
                        IdTiposUsuario = u.IdTipoUsuarioNavigation.IdTiposUsuario,
                        UsuarioLogin = u.IdTipoUsuarioNavigation.UsuarioLogin,
                    }
                })
                .ToList();
        }
    }
}
