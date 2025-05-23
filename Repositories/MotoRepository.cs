using ChallengeMottu.Data;
using ChallengeMottu.Domain.Interfaces;
using ChallengeMottu.Entities;

namespace ChallengeMottu.Infrastructure.Data.Repositories
{
    public class MotoRepository : IMotoRepository
    {
        private readonly ApplicationDbContext _context;

        public MotoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Adicionar(Moto moto)
        {
            _context.Motos.Add(moto);
            _context.SaveChanges();
        }

        public Moto? ObterPorId(int id)
        {
            return _context.Motos.FirstOrDefault(m => m.Id == id);
        }

        public IEnumerable<Moto> ObterTodos()
        {
            return _context.Motos.ToList();
        }

        public void Atualizar(Moto moto)
        {
            _context.Motos.Update(moto);
            _context.SaveChanges();
        }

        public void Remover(Moto moto)
        {
            _context.Motos.Remove(moto);
            _context.SaveChanges();
        }
    }
}
