using AutoMapper;
using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using System.Linq;

namespace GameApi.Data.Profiles
{
    public class PlayerProfile : Profile
    {
        public PlayerProfile()
        {
            CreateMap<Player, ReadPlayerDto>().ForMember(dest => dest.Equipamentos,opt => opt.MapFrom(x => x.PlayerEquipamentos.Select(y => y.Equipamento)));
            CreateMap<CreatePlayerDto, Player>();
        }
    }
}
