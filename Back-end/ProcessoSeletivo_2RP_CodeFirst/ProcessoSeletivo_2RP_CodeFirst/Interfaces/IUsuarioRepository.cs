
using Microsoft.AspNetCore.Http;
using ProcessoSeletivo_2RP_CodeFirst.Domanis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessoSeletivo_2RP_CodeFirst.Interfaces
{
    public class IUsuarioRepository
    {
    
        Usuarios Login(string email, string senha);
        List<Usuarios> Listar();

        void Cadastrar(Usuarios novoUsuario);

        void Atualizar(int id, Usuarios usuarioAtualizado);

        
        void Deletar(int id);

        Usuarios BuscarPorId(int id);
    }
}
