
using ShiningShoppingApp.Interfaces;
using ShiningShoppingApp.Models;

namespace ShiningShoppingApp.Services
{
    public class CartService: ICartService
    {
        private readonly ICartRepo<int, Models.Cart> _cartRepository;
      //  private readonly ITokenService _tokenSevice;
        public CartService(ICartRepo<int,Cart> repository)// ITokenService tokenService)
        {
            _cartRepository = repository;
          //  _tokenSevice = tokenService;
        }
        
        public Cart GetCart(int userId){
          var cartDetails=_cartRepository.FindByUserId(userId);
          if (cartDetails!=null){
            return cartDetails;
          }
          return null;

        }
        public Cart AddCart(int userId,CartProducts cartProduct){
            var cartDetails = _cartRepository.AddCart(userId, cartProduct);
            return null;
        }
        public Cart DeleteCartByID(int cartProductId){
            return null;
        }
        public Cart UpdateCart(int cartId,List<CartProducts> cartProducts)
        {
            var cartDetails = _cartRepository.Update(cartId, cartProducts);
            return cartDetails;
        }
        public Cart DeleteCart(int userId)
        {
            throw new NotImplementedException();
        }
    }
}