using Cinema.Web.Models;
using Cinema.Web.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Cinema.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IBookingResposity _bookingResposity;
        public HomeController(IMovieRepository movieRepository, IBookingResposity bookingResposity)
        {
            _movieRepository = movieRepository;
            _bookingResposity = bookingResposity;
        }

        public async Task<IActionResult> Index()
        {
            var movies = await _movieRepository.GetMovies();
            return View(movies);
        }


        public async Task<IActionResult> Details(int movieId)
        {
            var movie = await _movieRepository.GetMovieById(movieId);

            return View(movie);

        }

        [HttpPost]
        [ActionName("Details")]
        public async Task<IActionResult> DetailsPost(MovieDto movieDto)
        {
            BookingDto booking = new()
            {
                MovieId = movieDto.MovieId,
                Date = DateTime.Now.Date,
                Time = DateTime.Now.TimeOfDay.ToString(),
                NoOfTickets = movieDto.Count,
                User = "User"
            };

            var bookingId = await _bookingResposity.CreateBooking(booking);

            return RedirectToAction("BookingStatus", new { id = bookingId });

        }

        public async Task<IActionResult> BookingStatus(int id)
        {
            var booking = await _bookingResposity.GetBokingById(id);
            return View(booking);
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