using Microsoft.EntityFrameworkCore;
using MoviesOnline.Data;
using MoviesOnline.Data.Models;
using MoviesOnline.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviesOnline.Services
{
    public class MovieService : IMovieService
    {
        private MoviesOnlineDbContext _db;

        public MovieService(MoviesOnlineDbContext db)
        {
            this._db = db;
        }

        public void Add(Movie newMovie)
        {
            this._db.Add(newMovie);
            this._db.SaveChanges();
        }

        public IEnumerable<Movie> GetAll()
        {
            return _db.Movies
                .Include(asset => asset.Genre)
                .Include(asset => asset.Rating);
        }

        public Movie GetById(int id)
        {
            return GetAll()
                .FirstOrDefault(movie => movie.Id == id);
        }

        public Genre GetGenre(int id)
        {
            return _db.Movies.FirstOrDefault(genre => genre.Id == id).Genre;
        }

        public Rating GetRating(int id)
        {
            return _db.Movies.FirstOrDefault(rating => rating.Id == id).Rating;
        }

        public string GetTitle(int id)
        {
            return _db.Movies.FirstOrDefault(t => t.Id == id).Title;
        }
    }
}
