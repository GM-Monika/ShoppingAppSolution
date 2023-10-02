using ShiningShoppingApp.Models;

namespace ShiningShoppingApp.Interfaces
{
    public interface IProductService
    {
        public List<Product> GetAll();
        public Product GetById(int id);
        public Product Add(Product productDTO);

    }
}
