using AutoMapper;
using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApi.Data.Profiles
{
    public class PlayerEquipamentoProfile : Profile
    {
        public PlayerEquipamentoProfile()
        {
            CreateMap<CreatePlayerEquipamentoDto, PlayerEquipamentos>();
            CreateMap<PlayerEquipamentos, PlayersDoEquipamento>();
            CreateMap<PlayerEquipamentos, EquipamentosDoPlayer>();
        }
    }
}
