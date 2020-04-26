using AutoMapper;
using Models.Profile.Data.Entities;
using Models.Profile.Dto;

namespace Api.Profile
{
    public class AutoMapperConfig : AutoMapper.Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<User, UserDTO>().ReverseMap();

            CreateMap<Address, AddressDTO>().ReverseMap();

            CreateMap<UserAddress, UserAddressDTO>().ReverseMap()
                .ForMember(dest => dest.User, act => act.Ignore());
        }
    }
}
