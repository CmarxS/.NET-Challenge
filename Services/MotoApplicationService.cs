// Application/Services/MotoApplicationService.cs
using System;
using System.Collections.Generic;
using ChallengeMottu.Application.Interfaces;
using ChallengeMottu.Domain.Interfaces;
using ChallengeMottu.DTOs;
using ChallengeMottu.Entities;

namespace ChallengeMottu.Application.Services
{
    public class MotoApplicationService : IMotoApplicationService
    {
        private readonly IMotoRepository _repository;

        public MotoApplicationService(IMotoRepository repository)
        {
            _repository = repository;
        }

        public Moto? ObterMotoPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public IEnumerable<Moto> ObterTodasMotos()
        {
            return _repository.ObterTodos();
        }

        public void CriarMoto(MotoCreateDto motoDto)
        {
            var moto = new Moto
            {
                Modelo = motoDto.Modelo,
                AnoFabricacao = motoDto.AnoFabricacao,
                Categoria = motoDto.Categoria
            };

            _repository.Adicionar(moto);
        }

        public void AtualizarMoto(int id, MotoCreateDto motoDto)
        {
            var moto = _repository.ObterPorId(id);
            if (moto == null)
                throw new ArgumentException("Moto não encontrada.");

            moto.Modelo = motoDto.Modelo;
            moto.AnoFabricacao = motoDto.AnoFabricacao;
            moto.Categoria = motoDto.Categoria;

            _repository.Atualizar(moto);
        }

        public void DeletarMoto(int id)
        {
            var moto = _repository.ObterPorId(id);
            if (moto == null)
                throw new ArgumentException("Moto não encontrada.");

            _repository.Remover(moto);
        }
    }
}
