using System.ComponentModel.DataAnnotations.Schema;

namespace ShiningShoppingApp.Models
{
    public class Orders
    {
        public int Id { get; set; }
        [ForeignKey("Users")]
        public int UserId { get; set; }
        public Users User { get; set; }
    }
}
