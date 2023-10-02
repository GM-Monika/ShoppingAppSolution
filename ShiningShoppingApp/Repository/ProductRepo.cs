using ShiningShoppingApp.Context;
using ShiningShoppingApp.Interfaces;
using ShiningShoppingApp.Models;
namespace ShiningShoppingApp.Repository
{
    public class ProductRepo : IProductRepo<int, Product>
    {

        private readonly UserContext _context;
        public ProductRepo(UserContext context)
        {
            _context = context;
        }

        public Product Add(Product productDTO)
        {
            _context.ProductDetails.Add(productDTO);
            _context.SaveChanges();
            return productDTO;
        }

        public Product FindById(int id)
        {
            Product product=_context.ProductDetails.Find(id);
            return product;
        }

        public List<Product> GetAll() {
            List<Product> products = _context.ProductDetails.ToList();
            return products;
        }
    }
}
