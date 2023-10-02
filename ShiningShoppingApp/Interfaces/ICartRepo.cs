using ShiningShoppingApp.Models;
namespace ShiningShoppingApp.Interfaces
{
    public interface ICartRepo<K,T>
    {
        public T AddCart(K userId,CartProducts cartProduct);
        public List<T> GetAllCart(); 
        public T FindByUserId(K userId);
        public T DeleteByUserId(int id);
        public T DeleteByProductId( K productDetailsId);
        public T Update(K cartId, List<CartProducts> cartProduct);
    }
}