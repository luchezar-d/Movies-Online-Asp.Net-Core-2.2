using MoviesOnline.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesOnline.Services.Interfaces
{
    public interface IRatingService
    {
        void Add(Rating newRating);
        Rating GetById(int id);
        IEnumerable<Rating> GetAll();
    }
}
