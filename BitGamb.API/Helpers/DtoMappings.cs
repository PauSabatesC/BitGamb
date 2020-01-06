using AutoMapper;
using BitGamb.API.Models;
using BitGamb.API.DTOs;
using System;

namespace BitGamb.API.Helpers
{
    public class DtoMappings : Profile
    {
        public DtoMappings()
        {
            CreateMap<Robot, RobotsDTO>();
            CreateMap<User, UserInfoDTO>();

        }


    }
}