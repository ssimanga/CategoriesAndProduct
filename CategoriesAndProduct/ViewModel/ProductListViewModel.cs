using System.ComponentModel.DataAnnotations;

namespace CategoriesAndProduct.ViewModel
{
    public class ProductListViewModel
    {
        public int Id { get; set; }   
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Color { get; set; }
        public int Price { get; set; }
        public string? Image { get; set; }
        public int CategoryId { get; set; } 
        public string? CategoryName{ get; set; }
    }
}
