using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using System.Collections.Generic;

namespace GameApi.Domain.Interfaces
{
    public interface IEquipamentoRepository
    {
        Equipamento RetornaEquipamentoPorId(int id);
        void AdicionaEquipamento(Equipamento equipamento);
        List<Equipamento> RetornaTodosOsEquipamentos();
        void AtualizaEquipamento(Equipamento novoEquipamento);
        void DeletaEquipamento(Equipamento equipamento);
    }
}