using System.Collections.Generic;
using ChallengeMottu.DTO;
using ChallengeMottu.Entities;

namespace ChallengeMottu.Application.Interfaces
{
    public interface IFuncionarioApplicationService
    {
        Funcionario? ObterPorId(int id);
        IEnumerable<Funcionario> ObterTodos();
        void Criar(FuncionarioCreateDto dto);
        void Atualizar(int id, FuncionarioCreateDto dto);
        void Deletar(int id);
    }
}
