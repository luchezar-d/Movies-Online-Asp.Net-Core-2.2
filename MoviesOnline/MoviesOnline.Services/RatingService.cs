using MoviesOnline.Data;
using MoviesOnline.Data.Models;
using MoviesOnline.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviesOnline.Services
{
    public class RatingService : IRatingService
    {
        private readonly MoviesOnlineDbContext _db;

        public RatingService(MoviesOnlineDbContext _db)
        {
            this._db = _db;
        }

        public IEnumerable<Rating> GetAll()
        {
            return this._db.Ratings;
        }

        public Rating GetById(int id)
        {
            return GetAll()
                     .FirstOrDefault(rating => rating.Id == id);
        }
    }
}
