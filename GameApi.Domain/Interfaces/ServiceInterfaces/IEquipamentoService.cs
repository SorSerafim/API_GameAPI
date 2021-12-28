using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using System.Collections.Generic;

namespace GameApi.Domain.Interfaces.ServiceInterfaces
{
    public interface IEquipamentoService
    {
        public ReadEquipamentoDto RetornaEquipamentoPorId(int id);
        public List<ReadEquipamentoDto> RetornaTodosOsEquipamentos();
        public void AdicionaEquipamento(CreateEquipamentoDto equipamentoDto);
        public void AtualizaEquipamento(int id, CreateEquipamentoDto equipamentoDto);
        public void DeletaEquipamento(int id);
    }
}