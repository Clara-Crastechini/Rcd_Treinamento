using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using rcd_treinamento.Domains;
using rcd_treinamento.Interface;

namespace rcd_treinamento.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class PersonagemController : ControllerBase
    {
        private readonly IPersonagemRepository _personagemRepository;

        public PersonagemController(IPersonagemRepository personagemRepository)
        {
            _personagemRepository = personagemRepository;
        }



        [HttpPost]
        public IActionResult Post(Personagem novoPersonagem)
        {
            try
            {
                _personagemRepository.Cadastrar(novoPersonagem);
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
                _personagemRepository.Deletar(Id);
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
                return Ok(_personagemRepository.Listar());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }



        [HttpPut("{id}")]
        public IActionResult Put(Guid id, Personagem personagem)
        {
            try
            {
                _personagemRepository.Atualizar(id, personagem);

                return StatusCode(204, personagem);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
