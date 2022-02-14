using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo23_WebApp.Models
{

    [Table("Products")]
    public class Product
    {

        [Display(Name = "Product ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Display(Name = "Name of the Product")]
        [Required(ErrorMessage = "{0} cannot be empty.")]
        [StringLength(60, ErrorMessage = "{0} cannot have more than {1} characters.")]
        [MinLength(3, ErrorMessage = "{0} should contain more than {1} characters.")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "{0} cannot be empty.")]
        [Range(minimum: 1, maximum: 100, ErrorMessage = "{0} needs to be between {1} and {2}.")]
        public int Price { get; set; }

        [Required(ErrorMessage = "{0} cannot be empty.")]
        [Range(minimum: 1, maximum: 100, ErrorMessage = "{0} needs to be between {1} and {2}.")]
        public int Quantity { get; set; }
    }
}
