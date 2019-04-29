using MoviesOnline.Data.Models;
using MoviesOnline.ViewModels.GenreViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesOnline.Services.Interfaces
{
    public interface IGenreService
    {
        Genre GetById(int id);
        IEnumerable<Genre> GetAll();
        void Add(Genre newGenre);
    }
}
