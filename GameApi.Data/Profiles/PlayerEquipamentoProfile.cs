using AutoMapper;
using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;

namespace GameApi.Data.Profiles
{
    public class PlayerEquipamentoProfile : Profile
    {
        public PlayerEquipamentoProfile()
        {
            CreateMap<CreatePlayerEquipamentoDto, PlayerEquipamentos>();
        }
    }
}