using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "The R.M.",
                    ReleaseDate = DateTime.Parse("2003-1-31"),
                    Genre = "Comedy",
                    Price = 7.99M,
                    Rating = "PG",
                    ImageUrl = "https://www.churchofjesuschrist.org/imgs/f534f074cc36343cc0e77c8aae0849729514bebf/full/500%2C/0/default"

                },
                new Movie
                {
                    Title = "The Other Side of Heaven",
                    ReleaseDate = DateTime.Parse("2001-12-14"),
                    Genre = "Drama",
                    Price = 8.99M,
                    Rating = "PG",
                    ImageUrl = "https://cc-prod.scene7.com/is/image/CCProdAuthor/What-is-Stock-Photography_P1_mobile?$pjpeg$&jpegSize=100&wid=599"


                },
                new Movie
                {
                    Title = "Meet the Mormons",
                    ReleaseDate = DateTime.Parse("2014-10-10"),
                    Genre = "Documentary",
                    Price = 9.99M,
                    Rating = "PG",
                    ImageUrl = "https://cc-prod.scene7.com/is/image/CCProdAuthor/What-is-Stock-Photography_P1_mobile?$pjpeg$&jpegSize=100&wid=599"


                },
                new Movie
                {
                    Title = "The Best Two Years",
                    ReleaseDate = DateTime.Parse("2004-2-20"),
                    Genre = "Comedy",
                    Price = 3.99M,
                    Rating = "PG",
                    ImageUrl = "https://cc-prod.scene7.com/is/image/CCProdAuthor/What-is-Stock-Photography_P1_mobile?$pjpeg$&jpegSize=100&wid=599"



                }
            ); ;
            context.SaveChanges();
        }
    }
}