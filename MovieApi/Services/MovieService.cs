using System;
using System.Collections.Generic;
using System.Linq;
using MovieApi.Models;

namespace MovieApi.Services
{
    public class MovieService
    {
        public IEnumerable<Movie> GetAllMovies()
        {
            return Movies;
        }

        public IEnumerable<Movie> GetMoviesByGenre(string genre)
        {
            return Movies.Where(movie => movie.Genre.Contains(genre));
        }

        public IEnumerable<Movie> SearchMoviesByTitle(string title)
        {
            return (title == null ? Movies : Movies.Where(movie => movie.Title.IndexOf(title, StringComparison.OrdinalIgnoreCase) >= 0));
        }

        private static readonly List<Movie> Movies = new List<Movie>
        {
            new Movie
            {
                Title = "The Shawshank Redemption",
                Year = 1994,
                Genre = new List<string>{"Crime", "Drama"},
                Director = "Frank Darabont",
                Actors = new List<string>{"Tim Robbins", "Morgan Freeman"},
                Rating = 9.3
            },
            new Movie
            {
                Title = "The Godfather",
                Year = 1972,
                Genre = new List<string>{"Crime", "Drama"},
                Director = "Francis Ford Coppola",
                Actors = new List<string>{"Marlon Brando", "Al Pacino", "James Caan"},
                Rating = 9.2
            },
            new Movie
            {
                Title = "The Dark Knight",
                Year = 2008,
                Genre = new List<string>{"Action", "Crime", "Drama"},
                Director = "Christopher Nolan",
                Actors = new List<string>{"Christian Bale", "Heath Ledger", "Gary Oldman"},
                Rating = 9.0
            },
            new Movie
            {
                Title = "Inception",
                Year = 2010,
                Genre = new List<string>{"Action", "Adventure", "Sci-Fi"},
                Director = "Christopher Nolan",
                Actors = new List<string>{"Leonardo DiCaprio", "Joseph Gordon-Levitt", "Ellen Page"},
                Rating = 8.8
            }
        };
    }
}
