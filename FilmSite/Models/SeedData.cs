using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmSite.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FilmSiteContext(serviceProvider.GetRequiredService<DbContextOptions<FilmSiteContext>>()))
            {
                //check to make sure the database is empty
                if (context.Movie.Any())
                {
                    return; //if it isn't empty leave it
                }

                //Titles to add into the database if empty
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The Terminator",
                        ReleaseDate = DateTime.Parse("1984-10-04"),
                        Genre = "Action",
                        Price = 100M
                    },

                    new Movie
                    {
                        Title = "Terminator 2",
                        ReleaseDate = DateTime.Parse("1991-7-01"),
                        Genre = "Action",
                        Price = 519.8M
                    },

                    new Movie
                    {
                        Title = "Alien",
                        ReleaseDate = DateTime.Parse("1979-5-25"),
                        Genre = "Horror",
                        Price = 104.9M
                    },
                    new Movie
                    {
                        Title = "Aliens",
                        ReleaseDate = DateTime.Parse("1986-11-06"),
                        Genre = "Action",
                        Price = 131.1M
                    },
                    new Movie
                    {
                        Title = "Alien 3",
                        ReleaseDate = DateTime.Parse("1992-05-22"),
                        Genre = "Action",
                        Price = 159.8M
                    }
                    );
                context.SaveChanges();

            }
        }
    }
}
