using ShiningShoppingApp.Context;
using ShiningShoppingApp.Interfaces;
using ShiningShoppingApp.Models;

namespace ShiningShoppingApp.Repository
{
    public class CartRepo: ICartRepo<int,Cart>
    {
         private readonly UserContext _context;
        public CartRepo(UserContext context)
        {
            _context = context;
        }
        public List<Cart> GetAllCart(){
            var cartDetails = _context.CartDetails.ToList();
            return cartDetails;
        }
        public Cart FindByUserId(int userId){
            var cartDetails=_context.CartDetails.FirstOrDefault(cartDetails=> cartDetails.UserId==userId);
            return cartDetails;
            
        }
        public Cart DeleteByUserId(int id){
            var cartDetails=_context.CartDetails.FirstOrDefault(cartDetails=>cartDetails.Id==id);
            _context.CartDetails.Remove(cartDetails);
            _context.SaveChanges();
            return cartDetails;
        }
        public Cart DeleteByProductId(int productDetailsId){
            var productDetails=_context.CartProduct.FirstOrDefault(cartProductDetails=>cartProductDetails.Id==productDetailsId);
            _context.CartProduct.Remove(productDetails);
            _context.SaveChanges();
            var cart=_context.CartDetails.FirstOrDefault(cart=>cart.Id==productDetails.CartId);
            return cart; 
        }
        public Cart Update(int cartId ,List<CartProducts> cartProducts){
            var cartDetails=_context.CartDetails.FirstOrDefault(cart=>cart.Id==cartId);
            cartDetails.ProductsList = cartProducts;
            var unwantedCartProducts = _context.CartProduct.Where(cartProduct => cartProduct.CartId == cartId).ToList();
            if (unwantedCartProducts.Count() > 0)
            {
                _context.CartProduct.RemoveRange(unwantedCartProducts);

            }
            cartDetails.ProductsList = cartProducts;
            _context.Entry<Cart>(cartDetails).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.CartDetails.UpdateRange(cartDetails);
            _context.SaveChanges();
            return
                cartDetails;
         }

        public Cart AddCart(int userId , CartProducts cartProduct)
        {
            var cartDetails=_context.CartDetails.FirstOrDefault(cartdetails => cartdetails.UserId == userId);
            if (cartDetails == null)
            {
                var userDetails = _context.Users.FirstOrDefault(user => user.Id == userId);
                Cart cart = new Cart();
                cart.UserId = userDetails.Id;
                cart.ProductsList = new List<CartProducts>();
                cart.ProductsList.Add(cartProduct);
                cart.Users = userDetails;
                _context.CartDetails.Add(cart);
                _context.SaveChanges();

            }
                cartDetails = _context.CartDetails.FirstOrDefault(cartdetails => cartdetails.UserId == userId);

            return cartDetails;
        }
    }
}