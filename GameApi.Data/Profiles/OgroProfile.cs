using AutoMapper;
using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Read;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApi.Data.Profiles
{
    public class OgroProfile : Profile
    {
        public OgroProfile()
        {
            CreateMap<Ogro, ReadOgroDto>();
        }
    }
}
