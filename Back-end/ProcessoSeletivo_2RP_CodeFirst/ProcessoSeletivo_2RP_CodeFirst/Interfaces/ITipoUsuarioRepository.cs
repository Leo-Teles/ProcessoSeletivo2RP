
using ProcessoSeletivo_2RP_CodeFirst.Domanis;
using ProcessoSeletivo_2RP_CodeFirst.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace ProcessoSeletivo_2RP_CodeFirst.Interfaces
{
    public class ITipoUsuarioRepository
    {
        List<TiposUsuario> Listar();

        TiposUsuario BuscarPorId(int id);

        void Cadastrar(TiposUsuario novoTipoUsuario);

        
        void Atualizar(int id, TiposUsuario tipoUsuarioAtualizado);

        
        void Deletar(int id);

        public static implicit operator ITipoUsuarioRepository(TiposUsuarioRepository v)
        {
            throw new NotImplementedException();
        }
    }
}
