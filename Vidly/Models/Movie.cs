﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.EnterpriseServices;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        public Genre Genre { get; set; }
        
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }
        
        [Display( Name = "Release Date" )]
        public DateTime ReleaseDate { get; set; }

        public DateTime? DateAdded { get; set; }
        
        [Display(Name = "Number in Stock")]
        [NumberInStock]
        public byte NumberInStock { get; set; }
        
        public int NumberAvailable { get; set; }


        
    }
}