using AutoMapper;
using Models.Profile.Data.Entities;
using Models.Profile.Dto.Dtos;

namespace Api.Profile
{
    public class AutoMapperConfig: AutoMapper.Profile
    {

        public AutoMapperConfig()
        {
            CreateMap<User, UserDto>().ReverseMap();
        }
        
    }
}
