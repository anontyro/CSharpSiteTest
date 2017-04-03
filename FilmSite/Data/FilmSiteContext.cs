using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FilmSite.Models
{
    public class FilmSiteContext : DbContext
    {
        public FilmSiteContext (DbContextOptions<FilmSiteContext> options)
            : base(options)
        {
        }

        public DbSet<FilmSite.Models.Movie> Movie { get; set; }
    }
}
