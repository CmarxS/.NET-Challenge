using ChallengeMottu.Entities;

namespace ChallengeMottu.Domain.Interfaces
{
    public interface IMotoRepository
    {
        void Adicionar(Moto moto);
        Moto? ObterPorId(int id);
        IEnumerable<Moto> ObterTodos();
        void Atualizar(Moto moto);
        void Remover(Moto moto);
    }
}
