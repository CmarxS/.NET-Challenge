using System.Collections.Generic;
using ChallengeMottu.Entities;

namespace ChallengeMottu.Domain.Interfaces
{
    public interface IFuncionarioRepository
    {
        void Adicionar(Funcionario funcionario);
        Funcionario? ObterPorId(int id);
        IEnumerable<Funcionario> ObterTodos();
        void Atualizar(Funcionario funcionario);
        void Remover(Funcionario funcionario);
    }
}
