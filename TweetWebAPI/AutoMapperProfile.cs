using AutoMapper;
using TweetWebAPI.Dtos;
using TweetWebAPI.Models;

namespace TweetWebAPI
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();

            CreateMap<Tweet, TweetDto>();
            CreateMap<TweetDto, Tweet>();
        }
    }
}
