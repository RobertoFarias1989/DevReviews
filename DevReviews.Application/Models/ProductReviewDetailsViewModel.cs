using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevReviews.Application.Models
{
    public class ProductReviewDetailsViewModel
    {
        public ProductReviewDetailsViewModel(int id, string author, int rating, string comments, DateTime registeredAt)
        {
            Id = id;
            Author = author;
            Rating = rating;
            Comments = comments;
            RegisteredAt = registeredAt;
        }

        public int Id { get; private set; }
        public string Author { get; private set; }
        public int Rating { get; private set; }
        public string Comments { get; private set; }
        public DateTime RegisteredAt { get; private set; }
    }
}
