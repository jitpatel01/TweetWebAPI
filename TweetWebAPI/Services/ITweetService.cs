using TweetWebAPI.Dtos;

namespace TweetWebAPI.Services
{
    public interface ITweetService
    {
        Task<ServiceResponse<int>> AddTweet(TweetDto tweetDto, string userName);
    }
}
