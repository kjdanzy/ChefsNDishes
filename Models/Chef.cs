using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ChefsNDishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EighteenOrOlder]
        public DateTime DateOfBirth { get; set; }

        public List<Dish> Dishes { get; set; }

    }

    public class EighteenOrOlder : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            if (value is DateTime)
            {
                DateTime checkMe;
                checkMe = (DateTime)value;

                if (checkMe > DateTime.Now.AddYears(-18))
                {
                    return new ValidationResult("You must be 18 or older. Please check your 'Date of Birth'.");
                }
                else
                {
                    return ValidationResult.Success;
                }
            }
            else
            {
                return new ValidationResult("not a 'DateTime'");
            }
        }
    }
}