using ChallengeMottu.Data;
using ChallengeMottu.DTO;
using ChallengeMottu.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChallengeMottu.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MotoController : ControllerBase
    {
        private readonly ApplicationDbContext _ctx;

        public MotoController(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        // GET: api/moto
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var motos = await _ctx.Motos.ToListAsync();
            return Ok(motos);
        }

        // GET: api/moto/{id}
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var moto = await _ctx.Motos.FindAsync(id);
            if (moto == null) return NotFound();
            return Ok(moto);
        }

        // POST: api/moto
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] MotoCreateDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var moto = new Moto
            {
                Modelo = dto.Modelo,
                AnoFabricacao = dto.AnoFabricacao,
                Categoria = dto.Categoria,
                Placa = dto.Placa
            };

            _ctx.Motos.Add(moto);
            await _ctx.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetById),
                new { id = moto.Id },
                moto
            );
        }

        // PUT: api/moto/{id}
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, [FromBody] MotoCreateDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var moto = await _ctx.Motos.FindAsync(id);
            if (moto == null) return NotFound();

            moto.Modelo = dto.Modelo;
            moto.AnoFabricacao = dto.AnoFabricacao;
            moto.Categoria = dto.Categoria;

            await _ctx.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/moto/{id}
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var moto = await _ctx.Motos.FindAsync(id);
            if (moto == null) return NotFound();

            _ctx.Motos.Remove(moto);
            await _ctx.SaveChangesAsync();
            return NoContent();
        }
    }
}
