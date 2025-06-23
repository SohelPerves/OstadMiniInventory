using System.ComponentModel.DataAnnotations;

namespace OstadMiniInventory.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Category { get; set; } = string.Empty;

        [Range(0, double.MaxValue)]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }

        public string Status => Quantity switch
        {
            >= 10 => "In Stock",
            > 0 => "Low Stock",
            _ => "Out of Stock"
        };
    }
}
