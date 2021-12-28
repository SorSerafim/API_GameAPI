using AutoMapper;
using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;

namespace GameApi.Data.Profiles
{
    public class PlayerEquipamentoProfile : Profile
    {
        public PlayerEquipamentoProfile()
        {
            CreateMap<CreatePlayerEquipamentoDto, PlayerEquipamentos>();
            CreateMap<PlayerEquipamentos, ReadPlayerEquipamentoDto>();
        }
    }
}