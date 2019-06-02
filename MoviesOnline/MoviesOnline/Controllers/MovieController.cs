using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MoviesOnline.Data;
using MoviesOnline.Data.Models;
using MoviesOnline.Services.Interfaces;
using MoviesOnline.ViewModels;
using MoviesOnline.ViewModels.MovieViewModels;

namespace MoviesOnline.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService services;
        private readonly MoviesOnlineDbContext db;

        public MovieController(IMovieService services, MoviesOnlineDbContext db)
        {
            this.services = services;
            this.db = db;
        }

        public IActionResult Index()
        {
            var movieModels = services.GetAll();

            var listingResult = movieModels.Select(result => new MoviesListingViewModel {
                Id = result.Id,
                ImageUrl = result.ImageUrl,
                Title = result.Title,
                Genre = result.Genre.Name,
                Rating = result.Rating.RatingValue
            });

            var model = new MoviesIndexViewModel
            {
                movies = listingResult
            };

            return View(model);
        }
        public IActionResult Detail(int id)
        {
            var movie = services.GetById(id);

            var model = new MoviesDetailViewModel
            {
                MovieId = id,
                Title = movie.Title,
                ImageUrl = movie.ImageUrl,
                Genre = movie.Genre,
                Rating = movie.Rating
            };

            return View(model);
        }

        public IActionResult Create()
        {
            var model = new MovieCreateViewModel();

            ViewBag.Rating = new SelectList(db.Ratings, "Id", "RatingValue");
            ViewBag.Genre = new SelectList(db.Genres, "Id", "Name");

            return View(model);
        }

        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            

            var model = new MovieCreateViewModel
            {
                Id = movie.Id,
                ImageUrl = movie.ImageUrl,
                Title = movie.Title,
                Genre = movie.Genre,
                Rating = movie.Rating
            };

            ViewBag.Rating = new SelectList(db.Ratings, "Id", "RatingValue");
            ViewBag.Genre = new SelectList(db.Genres, "Id", "Name");

            services.Add(movie);

            return RedirectToAction("Index", "Movie");
        }
    }
}