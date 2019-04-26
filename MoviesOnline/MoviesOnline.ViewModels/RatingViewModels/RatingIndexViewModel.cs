using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesOnline.ViewModels.RatingViewModels
{
    public class RatingIndexViewModel
    {
        public IEnumerable<RatingListingViewModel> ratings { get; set; }
}
}
