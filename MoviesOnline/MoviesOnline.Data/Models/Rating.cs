using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesOnline.Data.Models
{
    public class Rating
    {
        public int Id { get; set; }

        public int RatingValue { get; set; }

        public List<Movie> Movies = new List<Movie>();
    }
}
