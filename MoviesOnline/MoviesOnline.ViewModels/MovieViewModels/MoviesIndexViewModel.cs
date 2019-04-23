using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesOnline.ViewModels.MovieViewModels
{
    public class MoviesIndexViewModel
    {
        public IEnumerable<MoviesListingViewModel> movies { get; set; }
    }
}
