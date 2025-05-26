using System.Collections.Generic;
using ChallengeMottu.DTOs;
using ChallengeMottu.Entities;

namespace ChallengeMottu.Application.Interfaces
{
    public interface IFilialApplicationService
    {
        Filial? ObterPorId(int id);
        IEnumerable<Filial> ObterTodas();
        void Criar(FilialCreateDto dto);
        void Atualizar(int id, FilialCreateDto dto);
        void Deletar(int id);
    }
}
