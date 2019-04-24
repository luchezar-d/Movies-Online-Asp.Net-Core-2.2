using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoviesOnline.Services.Interfaces;
using MoviesOnline.ViewModels;
using MoviesOnline.ViewModels.MovieViewModels;

namespace MoviesOnline.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _services;

        public MovieController(IMovieService services)
        {
            this._services = services;
        }

        public IActionResult Index()
        {
            var movieModels = _services.GetAll();

            var listingResult = movieModels.Select(result => new MoviesListingViewModel {
                Id = result.Id,
                ImageUrl = result.ImageUrl,
                Title = result.Title,
                Genre = result.Genre,
                Rating = result.Rating
            });

            var model = new MoviesIndexViewModel
            {
                movies = listingResult
            };

            return View(model);
        }
        public IActionResult Detail(int id)
        {
            var movie = _services.GetById(id);

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
    }
}