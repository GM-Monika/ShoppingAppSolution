using System.ComponentModel.DataAnnotations;

namespace ShiningShoppingApp.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Login? Login { get; set; }
         public List<Orders>? Order { get; set; }
        public Cart? Cart { get; set; }
         }
}
