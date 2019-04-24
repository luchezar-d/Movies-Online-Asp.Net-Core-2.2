using MoviesOnline.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesOnline.ViewModels.MovieViewModels
{
    public class MoviesDetailViewModel
    {
        public int MovieId { get; set; }

        public string Title { get; set; }

        public string ImageUrl { get; set; }

        public Genre Genre { get; set; }

        public Rating Rating { get; set; }
    }
}
