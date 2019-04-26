using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoviesOnline.Services.Interfaces;
using MoviesOnline.ViewModels.GenreViewModels;
using MoviesOnline.ViewModels.MovieViewModels;

namespace MoviesOnline.Controllers
{
    public class GenreController : Controller
    {
        private readonly IGenreService services;

        public GenreController(IGenreService service)
        {
            this.services = service;
        }

        public IActionResult Create(GenreListingViewModel model)
        {
            return View();
        }
        public IActionResult Index()
        {
            var genreModels = services.GetAll();

            var listingResult = genreModels.Select(result => new GenreListingViewModel
            {
                Id = result.Id,
                Name = result.Name
            });

            var model = new GenreIndexViewModel
            {
                genres = listingResult
            };

            return View(model);
        }
        public IActionResult Detail(int id)
        {
            var genre = services.GetById(id);

            var model = new GenreDetailViewModel
            {
                GenreId = id,
                Name = genre.Name
            };

            return View(model);
        }
    }
}