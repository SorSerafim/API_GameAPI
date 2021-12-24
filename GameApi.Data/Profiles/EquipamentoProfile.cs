using AutoMapper;
using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;

namespace GameApi.Data.Profiles
{
    public class EquipamentoProfile : Profile
    {
        public EquipamentoProfile()
        {
            CreateMap<CreateEquipamentoDto, Equipamento>();
            CreateMap<Equipamento, ReadEquipamentoDto>();
        }
    }
}