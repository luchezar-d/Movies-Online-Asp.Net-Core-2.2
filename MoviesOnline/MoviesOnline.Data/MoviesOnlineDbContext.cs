using Microsoft.EntityFrameworkCore;
using MoviesOnline.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesOnline.Data
{
    public class MoviesOnlineDbContext : DbContext
    {
        public MoviesOnlineDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Rating> Ratings { get; set; }
    }
}
