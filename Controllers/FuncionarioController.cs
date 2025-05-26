using Microsoft.AspNetCore.Mvc;
using ChallengeMottu.Application.Interfaces;
using ChallengeMottu.Entities;
using ChallengeMottu.DTO;

namespace ChallengeMottu.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioApplicationService _service;

        public FuncionarioController(IFuncionarioApplicationService service)
        {
            _service = service;
        }

        // GET: api/funcionario
        [HttpGet]
        public IActionResult GetAll()
        {
            var lista = _service.ObterTodos();
            return Ok(lista);
        }

        // GET: api/funcionario/{id}
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var func = _service.ObterPorId(id);
            if (func == null)
                return NotFound();
            return Ok(func);
        }

        // POST: api/funcionario
        [HttpPost]
        public IActionResult Create([FromBody] FuncionarioCreateDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _service.Criar(dto);
            return NoContent();
        }

        // PUT: api/funcionario/{id}
        [HttpPut("{id:int}")]
        public IActionResult Update(int id, [FromBody] FuncionarioCreateDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _service.Atualizar(id, dto);
            return NoContent();
        }

        // DELETE: api/funcionario/{id}
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            _service.Deletar(id);
            return NoContent();
        }
    }
}
