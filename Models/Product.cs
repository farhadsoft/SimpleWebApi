using System;
using System.ComponentModel.DataAnnotations;

namespace SimpleWebApi.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}