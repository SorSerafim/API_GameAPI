using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApi.Domain.Interfaces
{
    public interface IEquipamentoRepository
    {
        public void AdicionaEquipamento(CreateEquipamentoDto equipamentoDto);

        public List<ReadEquipamentoDto> RetornaTodosOsEquipamentos();

        public void AtualizaEquipamento(int id, Equipamento novoEquipamento);

        public void DeletaEquipamento(int id);
    }
}