using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevReviews.Core.Entities
{
    public class ProductReview
    {
        public ProductReview(string author, int rating, string comments,int productId)
        {
            
            Author = author;
            Rating = rating;
            Comments = comments;            
            ProductId = productId;

            RegisteredAt = DateTime.Now;
        }

        public int Id { get; private set; }
        public string Author { get; private set; }
        public int Rating { get; private set; }
        public string Comments { get; private set; }
        public DateTime RegisteredAt { get; set; }
        public int ProductId { get; set; }        
    }
}
