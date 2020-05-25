using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShoppingCartLab.Models;

namespace ShoppingCartLab.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly static CartModel masterCart = new CartModel();
        private CartModel usersCart = new CartModel();

        static HomeController () {
            masterCart.AddMovie(new MovieModel(1, "The Shawshank Redemption", "Drama"));
            masterCart.AddMovie(new MovieModel(2, "The Godfather", "Drama"));
            masterCart.AddMovie(new MovieModel(3, "The Dark Knight", "Action, Crime, Drama"));
            masterCart.AddMovie(new MovieModel(4, "The Lord of the Rings: The Return of the King", "Adventure, Drama, Fantasy"));
            masterCart.AddMovie(new MovieModel(5, "Pulp Fiction", "Crime, Drama"));
            masterCart.AddMovie(new MovieModel(6, "Schindler's List", "Biography, Drama, History"));
        }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult AddMovie(int movieId)
        {
            //_logger.LogDebug("log debug: in addmovie; userCart" + usersCart.movies.Count() );
            getUserCart();
            bool success = usersCart.AddMovie(masterCart.moviesList[movieId-1]);
            if (!success)
            {
                ViewBag.alreadyAdded = masterCart.moviesList[movieId - 1];
                return View("MovieList", masterCart);
            }
            string json = JsonSerializer.Serialize(usersCart.moviesList);
            _logger.LogError("log json=" + json );
            HttpContext.Session.SetString("MovieCart", json);
            return View("CartList", usersCart);
        }

        public IActionResult Receipt()
        {
            getUserCart();
            HttpContext.Session.Clear();
            ViewBag.emptyCart = true;
            return View("Receipt", usersCart);
        }

        private void getUserCart()
        {
            string json = HttpContext.Session.GetString("MovieCart");
            if (json != null)
            {
                usersCart.moviesList = JsonSerializer.Deserialize<List<MovieModel>>(json);
            }
        }

        public IActionResult CartList()
        {
            getUserCart();
            return View(usersCart);
        }

        public IActionResult MovieList()
        {
            string json = HttpContext.Session.GetString("MovieCart");
            if (json == null)
            {
                ViewBag.emptyCart = true;
            }
            return View(masterCart);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
