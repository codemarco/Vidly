using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true, NullDisplayText = "Not specified")]
        [Required]
        public DateTime ReleaseDate { get; set; }= DateTime.Now;
        [Required]
        public DateTime DateTime { get; set; } = DateTime.Now;
        [Required]
        public int NumberInStock { get; set; } = 0;
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
    }
}