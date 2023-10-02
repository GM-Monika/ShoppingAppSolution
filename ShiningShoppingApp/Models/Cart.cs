using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShiningShoppingApp.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
       public List<CartProducts> ProductsList { get; set; }
        [ForeignKey("Users")]
        public int UserId { get; set; }
        public Users Users { get; set; }
          }}
