using AutoMapper;
using VillaAPI.Dto;
using VillaAPI.Models;

namespace VillaAPI.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Villa,VillaDto>();
            CreateMap<VillaDto, Villa>();
        }
    }
}
