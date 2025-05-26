using System.Collections.Generic;
using System.Linq;
using ChallengeMottu.Data;
using ChallengeMottu.Domain.Interfaces;
using ChallengeMottu.Entities;

namespace ChallengeMottu.Infrastructure.Data.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly ApplicationDbContext _context;

        public FuncionarioRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Adicionar(Funcionario funcionario)
        {
            _context.Funcionarios.Add(funcionario);
            _context.SaveChanges();
        }

        public Funcionario? ObterPorId(int id)
        {
            return _context.Funcionarios.FirstOrDefault(f => f.Id == id);
        }

        public IEnumerable<Funcionario> ObterTodos()
        {
            return _context.Funcionarios.ToList();
        }

        public void Atualizar(Funcionario funcionario)
        {
            _context.Funcionarios.Update(funcionario);
            _context.SaveChanges();
        }

        public void Remover(Funcionario funcionario)
        {
            _context.Funcionarios.Remove(funcionario);
            _context.SaveChanges();
        }
    }
}
