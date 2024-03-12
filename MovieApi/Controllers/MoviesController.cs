using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MovieApi.Models;
using MovieApi.Services;

namespace MovieApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly MovieService _movieService;

        public MoviesController(MovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return _movieService.GetAllMovies();
        }

        [HttpGet("genre")]
        public IEnumerable<Movie> GetByGenre([FromQuery] string genre)
        {
            return _movieService.GetMoviesByGenre(genre);
        }

        [HttpGet("search")]
        public IEnumerable<Movie> SearchByTitle([FromQuery] string title)
        {
            return _movieService.SearchMoviesByTitle(title);
        }
    }
}
