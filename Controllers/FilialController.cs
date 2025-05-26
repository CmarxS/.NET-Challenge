// Controllers/FilialController.cs
using Microsoft.AspNetCore.Mvc;
using ChallengeMottu.Application.Interfaces;
using ChallengeMottu.DTOs;
using ChallengeMottu.Entities;

namespace ChallengeMottu.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilialController : ControllerBase
    {
        private readonly IFilialApplicationService _service;

        public FilialController(IFilialApplicationService service)
        {
            _service = service;
        }

        // GET: api/filial
        [HttpGet]
        public IActionResult GetAll()
        {
            var list = _service.ObterTodas();
            return Ok(list);
        }

        // GET: api/filial/{id}
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var f = _service.ObterPorId(id);
            if (f == null) return NotFound();
            return Ok(f);
        }

        // POST: api/filial
        [HttpPost]
        public IActionResult Create([FromBody] FilialCreateDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _service.Criar(dto);
            return NoContent();
        }

        // PUT: api/filial/{id}
        [HttpPut("{id:int}")]
        public IActionResult Update(int id, [FromBody] FilialCreateDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _service.Atualizar(id, dto);
            return NoContent();
        }

        // DELETE: api/filial/{id}
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            _service.Deletar(id);
            return NoContent();
        }
    }
}
