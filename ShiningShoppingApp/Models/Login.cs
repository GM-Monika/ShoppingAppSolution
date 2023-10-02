using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShiningShoppingApp.Models
{
    public class Login
    {
        [Key]
        public string Email { get; set; }
        public string Password { get; set; }
        [ForeignKey("Users")]
        public int? UserId { get;set; } 
        public Users? Users { get; set; }
    }
}
