using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DevReviews.Application.Models;

public class UpdateProductInputModel
{
    public int Id { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
}
