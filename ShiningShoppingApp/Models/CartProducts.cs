using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShiningShoppingApp.Models
{
    public class CartProducts
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Cart")]
        public int CartId { get; set; }
        public Cart? Cart { get; set; }
        [ForeignKey("Product")]
        public int  ProductID { get; set; }
        public Product? Product { get; set; }
        public int Quantity { get; set; }
        public decimal? UnitPrice { get; set;}
        public decimal? Price { get; set;}
    }
}
