using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models.Movies;

namespace WebApplication2.Controllers
{
    public class MoviesController : Controller
    {
        static List<Movie> movies = new List<Movie>
        {
            new Movie { Author = "Todd Phillips", Genre = "Crime , Drama , Thriller", Name = "Joker",
                Poster = "https://www.kinopoisk.ru/images/film_big/1048334.jpg",
                CreatedAt = new DateTime(2019,10,3)
            },
            new Movie { Author = "David Leitch", Genre = "Action , Adventure", Name = "Fast & Furious Presents: Hobbs & Shaw",
                Poster = "https://m.media-amazon.com/images/I/A1nD1zDE9pL._SS500_.jpg",
                CreatedAt = new DateTime(2019,8,2)
            },
            new Movie { Author = "Jon Favreau", Genre = "Adventure , Animation , Drama , Family , Musical", Name = "The Lion King",
                Poster = "https://lh3.googleusercontent.com/proxy/g1FRyZ57MZ4D5MwsAvZT-r8dEzX0xse8ccgrcrFI-hoVCcwAGCmoUxzOg-tWnL_am9kEcH4qmlbYhhQ",
                CreatedAt = new DateTime(2019,7,19)
            },
            new Movie { Author = "Joachim Rønning", Genre = "Adventure , Family , Fantasy", Name = "Maleficent: Mistress of Evil",
                Poster = "https://images-na.ssl-images-amazon.com/images/I/81I8lPvhPjL._SL1500_.jpg",
                CreatedAt = new DateTime(2019,10,18)
            },
        };


        public IActionResult Index()
        {

            return View(movies);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Movie movie)
        {
            movies.Add(movie);

            return View("Index", movies);
        }

        public IActionResult Search(string text)
        {
            text = text.ToLower();
            var searchedMovies = movies.Where(movie => movie.Name.ToLower().Contains(text)
                                            || movie.Genre.ToLower().Contains(text)
                                            || movie.Author.ToLower().Contains(text))
                                        .ToList();
            return View("Index", searchedMovies);
        }

    }
}