using MoviesOnline.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesOnline.Services.Interfaces
{
    public interface IMovieService
    {
        void Add(Movie newMovie);
        IEnumerable<Movie> GetAll();
        string GetTitle(int id);
        Movie GetById(int id);
        Genre GetGenre(int id);
        Rating GetRating(int id);
    }
}
