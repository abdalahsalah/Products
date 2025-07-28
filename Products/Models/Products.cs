using System.ComponentModel.DataAnnotations;

namespace Products.Models
{
    public class Products
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(100)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, 100000, ErrorMessage = "Price must be greater than 0")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1")]
        public int quantity { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public int categoriesId { get; set; }
        public categories? categories { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Title} - {Price} - {quantity} - {categories?.Name}";
        }


    }
}
