using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OrderApp.Models
{
    public class Product
    {
        [Required(ErrorMessage ="{0} Can't be blank")]
        [Range(1,int.MaxValue,ErrorMessage ="{0} Shold be a valid number")]
        [DisplayName("Product Code0")]
        public int ProductCode { get; set; }
        [Required(ErrorMessage = "{0} can't be blank")]
        [Display(Name = "Product Price ")]
        [Range(1, int.MaxValue, ErrorMessage = "{0} should be between a valid number")]
        public double Price { get; set; }
        [Required(ErrorMessage = "{0} can't be blank")]
        [Display(Name = "Product Quantity")]
        [Range(1, int.MaxValue, ErrorMessage = "{0} should be between a valid number")]
        public int Quantity { get; set; }
    }
}
