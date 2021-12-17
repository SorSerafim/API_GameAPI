using AutoMapper;
using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;

namespace GameApi.Data.Profiles
{
    public class PlayerProfile : Profile
    {
        public PlayerProfile()
        {
            CreateMap<Player, ReadPlayerDto>();
            CreateMap<CreatePlayerDto, Player>();
        }
    }
}
