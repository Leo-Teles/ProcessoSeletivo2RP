using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProcessoSeletivo_2RP_CodeFirst.Domanis;
using ProcessoSeletivo_2RP_CodeFirst.Interfaces;
using ProcessoSeletivo_2RP_CodeFirst.Repositories;
using System;

namespace ProcessoSeletivo_2RP_CodeFirst.Controllers
{

    [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]
    [Authorize(Roles = "1")]
    public class TiposUsuarioController : ControllerBase
    {
        private ITipoUsuarioRepository _tiposUsuarioRepository { get; set; }

      
        public TiposUsuarioController()
        {
            _tiposUsuarioRepository = new TiposUsuarioRepository();
        }

        
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_tiposUsuarioRepository.Listar());
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                
                return Ok(_tiposUsuarioRepository.BuscarPorId(id));
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        
        [HttpPost]
        public IActionResult Post(TiposUsuario novoTipousuario)
        {
            try
            {
                // Faz a chamada para o método
                _tiposUsuarioRepository.Cadastrar(novoTipousuario);

                // Retorna um status code
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        
        [HttpPut("{id}")]
        public IActionResult Put(int id, TiposUsuario tipoUsuarioAtualizado)
        {
            try
            {
                
                _tiposUsuarioRepository.Atualizar(id, tipoUsuarioAtualizado);

                
                return StatusCode(204);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

       
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                
                _tiposUsuarioRepository.Deletar(id);

                
                return StatusCode(204);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
