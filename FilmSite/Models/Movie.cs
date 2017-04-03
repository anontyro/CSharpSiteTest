using System;
using System.ComponentModel.DataAnnotations;

namespace FilmSite.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Display(Name = "Film Title")]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }

        [Display(Name ="US Box Office Gross")]
        public decimal Price { get; set; }

    }
}
