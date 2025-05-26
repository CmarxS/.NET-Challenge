using ChallengeMottu.Application.Interfaces;
using ChallengeMottu.Domain.Interfaces;
using ChallengeMottu.DTOs;
using ChallengeMottu.Entities;

namespace ChallengeMottu.Application.Services
{
    public class FilialApplicationService : IFilialApplicationService
    {
        private readonly IFilialRepository _repository;

        public FilialApplicationService(IFilialRepository repository)
        {
            _repository = repository;
        }

        public Filial? ObterPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public IEnumerable<Filial> ObterTodas()
        {
            return _repository.ObterTodos();
        }

        public void Criar(FilialCreateDto dto)
        {
            var filial = new Filial
            {
                NomeFilial = dto.NomeFilial,
                CodCidade = dto.CodCidade,
                TamanhoPatio = dto.TamanhoPatio
            };
            _repository.Adicionar(filial);
        }

        public void Atualizar(int id, FilialCreateDto dto)
        {
            var filial = _repository.ObterPorId(id);
            if (filial == null)
                throw new ArgumentException("Filial não encontrada.");

            filial.NomeFilial = dto.NomeFilial;
            filial.CodCidade = dto.CodCidade;
            filial.TamanhoPatio = dto.TamanhoPatio;

            _repository.Atualizar(filial);
        }

        public void Deletar(int id)
        {
            var filial = _repository.ObterPorId(id);
            if (filial == null)
                throw new ArgumentException("Filial não encontrada.");

            _repository.Remover(filial);
        }
    }
}
