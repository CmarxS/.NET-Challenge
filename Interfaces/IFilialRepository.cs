using System.Collections.Generic;
using ChallengeMottu.Entities;

namespace ChallengeMottu.Domain.Interfaces
{
    public interface IFilialRepository
    {
        void Adicionar(Filial filial);
        Filial? ObterPorId(int id);
        IEnumerable<Filial> ObterTodos();
        void Atualizar(Filial filial);
        void Remover(Filial filial);
    }
}
