using ShiningShoppingApp.Interfaces;
using ShiningShoppingApp.Models;
using System.Numerics;

namespace ShiningShoppingApp.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo<int, Product> _ProductRepo;
        public ProductService(IProductRepo<int, Product> productRepo) {
            _ProductRepo = productRepo;

        }
        public Product Add(Product productDTO)
        {
            var product=_ProductRepo.Add(productDTO);
            if (product!=null){
                return product;

            }
            return null;
        }

        public List<Product> GetAll()
        {
            var products = _ProductRepo.GetAll();

            if (products == null){
                return null;
            }
            return products;
        }

        public Product GetById(int id)
        {
            var product = _ProductRepo.FindById(id);
            return product;
        }
    }
}
