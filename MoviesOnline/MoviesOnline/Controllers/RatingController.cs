using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoviesOnline.Services;
using MoviesOnline.Services.Interfaces;
using MoviesOnline.ViewModels.RatingViewModels;

namespace MoviesOnline.Controllers
{
    public class RatingController : Controller
    {
        private readonly IRatingService services;

        public RatingController(IRatingService service)
        {
            this.services = service;
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Index()
        {
            var ratingModels = services.GetAll();

            var listingResult = ratingModels.Select(result => new RatingListingViewModel
            {
                Id = result.Id,
                RatingValue = result.RatingValue
            });

            var model = new RatingIndexViewModel
            {
                ratings = listingResult
            };

            return View(model);
        }
        public IActionResult Detail(int id)
        {
            var rating = services.GetById(id);

            var model = new RatingDetailViewModel
            {
                RatingId = id,
                RatingValue = rating.RatingValue
            };

            return View(model);
        }
    }
}