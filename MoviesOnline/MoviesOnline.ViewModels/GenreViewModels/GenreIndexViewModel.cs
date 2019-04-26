using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesOnline.ViewModels.GenreViewModels
{
    public class GenreIndexViewModel
    {
        public IEnumerable<GenreListingViewModel> genres { get; set; }
    }
}
