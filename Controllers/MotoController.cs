using ChallengeMottu.Data;
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
            => Ok(await _ctx.Motos.ToListAsync());

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
        public async Task<IActionResult> Create(Moto moto)
        {
            _ctx.Motos.Add(moto);
            await _ctx.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = moto.Id }, moto);
        }

        // PUT: api/moto/{id}
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update(int id, Moto moto)
        {
            if (id != moto.Id) return BadRequest();
            if (!await _ctx.Motos.AnyAsync(m => m.Id == id)) return NotFound();

            _ctx.Entry(moto).State = EntityState.Modified;
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

        [HttpGet("by-placa")]
        public async Task<IActionResult> GetByPlaca([FromQuery] string placa)
        {
            var list = await _ctx.Motos
                                 .Where(m => m.Placa == placa)
                                 .ToListAsync();
            return Ok(list);
        }
    }
}
