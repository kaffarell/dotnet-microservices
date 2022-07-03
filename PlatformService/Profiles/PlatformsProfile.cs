using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Profiles
{
    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
            // Source -> Target  (for read)
            CreateMap<Platform, PlatformReadDto>();
            // (for creation)
            CreateMap<PlatformCreateDto, Platform>();
        }
    }
}