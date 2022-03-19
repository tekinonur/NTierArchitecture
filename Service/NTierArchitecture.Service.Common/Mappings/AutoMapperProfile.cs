using AutoMapper;
using NTierArchitecture.Data.Model;
using NTierArchitecture.Service.Common.DTOs;

namespace NTierArchitecture.Service.Common.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
            CreateMap<Muhit, MuhitDTO>();
            CreateMap<MuhitDTO, Muhit>();

            //TODO: Reverse map uygulanmalı tekrara düşmemesi için
        }
    }
}
