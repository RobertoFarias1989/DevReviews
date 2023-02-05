using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevReviews.Application.Models
{
    public class AddProductReviewInputModel
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Author { get; set; }
        public string Comments { get; set; }
    }
}
