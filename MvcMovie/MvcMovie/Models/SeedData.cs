using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
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
                        Title = "God's Not Dead",
                        ReleaseDate = DateTime.Parse("2014-3-21"),
                        Genre = "Christian Drama",
                        Rating = "PG",
                        Price = 9.99M,
                        ImageName = "test.jpg"
                    },
                    new Movie
                    {
                        Title = "War Room",
                        ReleaseDate = DateTime.Parse("2015-8-28"),
                        Genre = "Faith-Based",
                        Rating = "PG",
                        Price = 10.99M,
                        ImageName = "test.jpg"
                    },
                    new Movie
                    {
                        Title = "Fireproof",
                        ReleaseDate = DateTime.Parse("2008-9-26"),
                        Genre = "Christian Romance",
                        Rating = "PG",
                        Price = 8.99M,
                        ImageName = "test.jpg"
                    },
                    new Movie
                    {
                        Title = "The Passion of the Christ",
                        ReleaseDate = DateTime.Parse("2004-2-25"),
                        Genre = "Biblical Drama",
                        Rating = "R",
                        Price = 12.99M,
                        ImageName = "test.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
