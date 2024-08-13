﻿using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class Combo
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public List<FoodItem> FoodItems { get; set; }
    }
}
