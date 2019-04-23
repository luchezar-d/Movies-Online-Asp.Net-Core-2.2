using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesOnline.Data.Models
{
    public class Genre
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Movie> Movies = new List<Movie>();
    }
}
