using System.ComponentModel.DataAnnotations;

namespace TweetWebAPI.Models
{
    public class Tweet
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(144)]
        public string Message { get; set; }

        [Required]
        [MaxLength(50)]
        public string Tag { get; set; }

        public ICollection<Tweet>? Tweets { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public User User { get; set; }
    }
}
