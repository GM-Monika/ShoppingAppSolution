
using ShiningShoppingApp.Models;

namespace ShiningShoppingApp.Interfaces
{
    public interface ICartService
    {
        public Cart UpdateCart(int cartId, List<CartProducts> cartProducts);
        public Cart GetCart(int userId);
        public Cart AddCart(int userId,CartProducts cartProduct);
        public Cart DeleteCartByID(int cartProductId);
        public Cart DeleteCart(int userId);
    }
}