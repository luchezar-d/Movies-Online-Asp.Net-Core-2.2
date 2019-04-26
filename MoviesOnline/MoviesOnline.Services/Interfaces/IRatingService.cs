using MoviesOnline.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesOnline.Services.Interfaces
{
    public interface IRatingService
    {
        Rating GetById(int id);
        IEnumerable<Rating> GetAll();
    }
}
