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

            CreateMap<Address, AddressDTO>().ReverseMap()
                //Ignoring the UserAddresses property of the destination type
                .ForMember(dest => dest.UserAddresses, act => act.Ignore());

            CreateMap<UserAddress, UserAddressDTO>().ReverseMap()
                //Ignoring the User property of the destination type
                .ForMember(dest => dest.User, act => act.Ignore());
        }
    }
}
