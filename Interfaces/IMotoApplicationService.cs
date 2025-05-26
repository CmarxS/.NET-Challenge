using ChallengeMottu.DTO;
using ChallengeMottu.Entities;

namespace ChallengeMottu.Application.Interfaces
{
    public interface IMotoApplicationService
    {
        Moto? ObterMotoPorId(int id);
        IEnumerable<Moto> ObterTodasMotos();
        void CriarMoto(MotoCreateDto motoDto);
        void AtualizarMoto(int id, MotoCreateDto motoDto);
        void DeletarMoto(int id);
    }
}
