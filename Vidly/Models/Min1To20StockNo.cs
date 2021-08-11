using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidly.Models
{
    public class Min1To20StockNo : ValidationAttribute
    {
        
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie) validationContext.ObjectInstance;

            if (movie.Stock==null)
                return new ValidationResult("Stock is required.");


            return (movie.Stock >= 1 && movie.Stock <=20)
                ? ValidationResult.Success
                : new ValidationResult("Number of stocks must be between 1 and 20");
        }
    }
}