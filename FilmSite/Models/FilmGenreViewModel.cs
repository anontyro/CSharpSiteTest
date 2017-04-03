using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace FilmSite.Models
{
    public class FilmGenreViewModel
    {
        public List<Movie> movies;
        public SelectList genres;
        public string movieGenre { get; set; }
    }
}
