using AutoMapper;
using TweetWebAPI.Data;
using TweetWebAPI.Dtos;
using TweetWebAPI.Models;

namespace TweetWebAPI.Services
{
    public class TweetService : ITweetService
    {
        private readonly TweetContext dataContext;
        private readonly IMapper mapper;

        public TweetService(IMapper mapper, TweetContext dataContext)
        {
            this.mapper = mapper;
            this.dataContext = dataContext;
        }

        public async Task<ServiceResponse<int>> AddTweet(TweetDto tweetDto, string userName)
        {
            ServiceResponse<int> response = new ServiceResponse<int>();
            if (string.IsNullOrEmpty(userName))
            {
                response.Success = false;
                response.Message = "User name is required.";
            }
            else
            {
                var user = dataContext.Users.FirstOrDefault(x => x.LoginId.ToLower() == userName.ToLower());

                if (user == null)
                {
                    response.Success = false;
                    response.Message = "User not exists.";
                }
                else
                {
                    Tweet tweet = this.mapper.Map<Tweet>(tweetDto);
                    tweet.User = dataContext.Users.FirstOrDefault(x => x.LoginId.ToLower() == userName.ToLower());

                    dataContext.Tweets.Add(tweet);
                    await dataContext.SaveChangesAsync();

                    response.Data = user.Id;
                    response.Message = "Tweet added successfully.";
                }
            }

            return response;
        }
    }
}
