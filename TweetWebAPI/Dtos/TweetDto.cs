namespace TweetWebAPI.Dtos
{
    public class TweetDto
    {
        public int Id { get; set; }

        public string Message { get; set; }

        public string Tag { get; set; }

        public int? TweetId { get; set; }
    }
}
