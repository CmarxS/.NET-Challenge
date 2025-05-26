using System;
using System.Collections.Generic;
using ChallengeMottu.Application.Interfaces;
using ChallengeMottu.Domain.Interfaces;
using ChallengeMottu.DTO;
using ChallengeMottu.Entities;

namespace ChallengeMottu.Application.Services
{
    public class FuncionarioApplicationService : IFuncionarioApplicationService
    {
        private readonly IFuncionarioRepository _repository;

        public FuncionarioApplicationService(IFuncionarioRepository repository)
        {
            _repository = repository;
        }

        public Funcionario? ObterPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public IEnumerable<Funcionario> ObterTodos()
        {
            return _repository.ObterTodos();
        }

        public void Criar(FuncionarioCreateDto dto)
        {
            var func = new Funcionario
            {
                Nome = dto.Nome,
                Email = dto.Email,
                TipoAcesso = dto.TipoAcesso,
                FuncaoUsuario = dto.FuncaoUsuario,
                IdFilial = dto.IdFilial
            };
            _repository.Adicionar(func);
        }

        public void Atualizar(int id, FuncionarioCreateDto dto)
        {
            var func = _repository.ObterPorId(id);
            if (func == null)
                throw new ArgumentException("Funcionário não encontrado.");

            func.Nome = dto.Nome;
            func.Email = dto.Email;
            func.TipoAcesso = dto.TipoAcesso;
            func.FuncaoUsuario = dto.FuncaoUsuario;
            func.IdFilial = dto.IdFilial;

            _repository.Atualizar(func);
        }

        public void Deletar(int id)
        {
            var func = _repository.ObterPorId(id);
            if (func == null)
                throw new ArgumentException("Funcionário não encontrado.");

            _repository.Remover(func);
        }
    }
}
