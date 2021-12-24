using AutoMapper;
using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;

namespace GameApi.Data.Profiles
{
    public class OgroProfile : Profile
    {
        public OgroProfile()
        {
            CreateMap<CreateOgroDto, Ogro>();
            CreateMap<Ogro, ReadOgroDto>();
        }
    }
}