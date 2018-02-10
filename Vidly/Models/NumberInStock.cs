using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class NumberInStock : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;



            var numbers = movie.NumberInStock;

            return ((numbers >= 1) && (numbers <=20))
                ? ValidationResult.Success
                : new ValidationResult("Number in Stock can be a number from 1 to 20");
        }
    }
}