using System.Collections.Generic;
using System.Linq;
using ChallengeMottu.Domain.Interfaces;
using ChallengeMottu.Entities;
using ChallengeMottu.Data;

namespace ChallengeMottu.Infrastructure.Data.Repositories
{
    public class FilialRepository : IFilialRepository
    {
        private readonly ApplicationDbContext _context;

        public FilialRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Adicionar(Filial filial)
        {
            _context.Filiais.Add(filial);
            _context.SaveChanges();
        }

        public Filial? ObterPorId(int id)
        {
            return _context.Filiais.FirstOrDefault(f => f.Id == id);
        }

        public IEnumerable<Filial> ObterTodos()
        {
            return _context.Filiais.ToList();
        }

        public void Atualizar(Filial filial)
        {
            _context.Filiais.Update(filial);
            _context.SaveChanges();
        }

        public void Remover(Filial filial)
        {
            _context.Filiais.Remove(filial);
            _context.SaveChanges();
        }
    }
}
