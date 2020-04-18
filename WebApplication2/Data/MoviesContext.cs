using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models.Movies;

namespace WebApplication2.Data
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = 1,
                Author = "Todd Phillips",
                Genre = "Crime , Drama , Thriller",
                Name = "Joker",
                Poster = "https://www.kinopoisk.ru/images/film_big/1048334.jpg",
                CreatedAt = new DateTime(2019, 10, 3)
            },
            new Movie
            {
                Id = 2,
                Author = "David Leitch",
                Genre = "Action , Adventure",
                Name = "Fast & Furious Presents: Hobbs & Shaw",
                Poster = "https://m.media-amazon.com/images/I/A1nD1zDE9pL._SS500_.jpg",
                CreatedAt = new DateTime(2019, 8, 2)
            },
            new Movie
            {
                Id = 3,
                Author = "Jon Favreau",
                Genre = "Adventure , Animation , Drama , Family , Musical",
                Name = "The Lion King",
                Poster = "https://images-na.ssl-images-amazon.com/images/I/91kXw97IUBL._AC_SL1500_.jpg",
                CreatedAt = new DateTime(2019, 7, 19)
            },
            new Movie
            {
                Id = 4,
                Author = "Joachim Rønning",
                Genre = "Adventure , Family , Fantasy",
                Name = "Maleficent: Mistress of Evil",
                Poster = "https://st.kp.yandex.net/images/film_iphone/iphone360_916498.jpg",
                CreatedAt = new DateTime(2019, 10, 18)
            });
        }
    }
}
