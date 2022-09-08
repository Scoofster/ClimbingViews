using System.ComponentModel.DataAnnotations;

namespace WebApplicationReviews.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string ReviewTitle { get; set; }
        public string ReviewContent { get; set; }

        public string ReviewLocation { get; set; }
        [Range (0, 99)]
        public int ReviewRating { get; set; }

        public string Rating
        {
            get
            {
                return ReviewRating + " / 99";
            }
        }
        public Review()
        {

        }
    }
}
