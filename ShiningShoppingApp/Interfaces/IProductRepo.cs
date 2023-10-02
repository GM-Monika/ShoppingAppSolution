using ShiningShoppingApp.Models;

namespace ShiningShoppingApp.Interfaces
{
    public interface IProductRepo<K,T>
    {
        public List<T> GetAll();
        public T FindById(K id);
        public T Add(T productDTO);
    }
}
