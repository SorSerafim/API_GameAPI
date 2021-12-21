using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using System.Collections.Generic;

namespace GameApi.Domain.Interfaces
{
    public interface IEquipamentoRepository
    {
        public Equipamento RetornaEquipamentoPorId(int id);
        public void AdicionaEquipamento(CreateEquipamentoDto equipamentoDto);
        public List<ReadEquipamentoDto> RetornaTodosOsEquipamentos();
        public void AtualizaEquipamento(int id, Equipamento novoEquipamento);
        public void DeletaEquipamento(int id);
    }
}