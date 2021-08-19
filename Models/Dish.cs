using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ChefsNDishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1, 5, ErrorMessage = "The field Tastiness must be between 1 and 5...")]
        public int Tastiness { get; set; }
        [Required]
        [Range(0.001, Int32.MaxValue, ErrorMessage = "The field Calories must be greater than 0...")]
        public int Calories { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int ChefId { get; set; }
        public Chef DishCreator { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}