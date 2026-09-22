using System;
using System.ComponentModel.DataAnnotations;

namespace ProductCatalogApp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Product name is required.")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [Range(1.00, 500000.00)]
        public decimal Price { get; set; }

        [Required]
        public string Category { get; set; }

        // Is property ko add karna zaroori tha
        public string ImageUrl { get; set; }

        public bool IsInStock { get; set; } = true;
    }
}