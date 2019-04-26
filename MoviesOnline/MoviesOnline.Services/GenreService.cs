using MoviesOnline.Data;
using MoviesOnline.Data.Models;
using MoviesOnline.Services.Interfaces;
using MoviesOnline.ViewModels.GenreViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviesOnline.Services
{
    public class GenreService : IGenreService
    {
        private readonly MoviesOnlineDbContext _db;

        public GenreService(MoviesOnlineDbContext _db)
        {
            this._db = _db;
        }

        public IEnumerable<Genre> GetAll()
        {
            return this._db.Genres;
        }

        public Genre GetById(int id)
        {
            return GetAll()
                     .FirstOrDefault(genre => genre.Id == id);
        }
    }
}
