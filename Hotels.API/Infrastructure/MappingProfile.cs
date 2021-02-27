using AutoMapper;
using Hotels.API.Entities;
using Hotels.API.Models;
using Hotels.API.Models.Derived;

namespace Hotels.API.Infrastructure
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        { // take roomEntity and convert Room
            CreateMap<RoomEntity, Room>()
                .ForMember(dest => dest.Rate, opt =>
                    opt.MapFrom(scr => scr.Rate / 100));

            CreateMap<UserEntity, UserInfo>()
                .ForMember(desc => desc.FullName, opt =>
                    opt.MapFrom(scr => string.Concat(scr.Name, scr.SurName)));
        }
    }
}