using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using rcd_treinamento.Domains;
using rcd_treinamento.Interface;

namespace rcd_treinamento.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }



        [HttpPost]
        public IActionResult Post(Usuario novoUsuario)
        {
            try
            {
                _usuarioRepository.Cadastrar(novoUsuario);
                return Created();
            }
            catch (Exception error)
            {

                return BadRequest(error.Message);
            }
        }



        [HttpDelete("{id}")]
        public IActionResult Delete(Guid Id)
        {
            try
            {
                _usuarioRepository.Deletar(Id);
                return NoContent();
            }
            catch (Exception error)
            {

                return BadRequest(error.Message);
            }
        }


        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_usuarioRepository.Listar());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }



        [HttpPut("{id}")]
        public IActionResult Put(Guid id, Usuario usuario)
        {
            try
            {
                _usuarioRepository.Atualizar(id, usuario);

                return StatusCode(204, usuario);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
