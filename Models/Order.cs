﻿using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; } // Pending, Delivered, In-Progress
        public List<OrderItem> OrderItems { get; set; }
    }
}
