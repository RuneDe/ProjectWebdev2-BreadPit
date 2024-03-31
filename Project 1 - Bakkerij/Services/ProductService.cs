using System.Collections.Generic;
using System.Linq;
using Project_1___Bakkerij.Data;
using Project_1___Bakkerij.Models;

namespace Project_1___Bakkerij.Services
{
    public class ProductService
    {
        private readonly ContosoBreadContext _context;

        public ProductService(ContosoBreadContext context)
        {
            _context = context;
        }

        public List<ProductModel> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public void CreateProduct(ProductModel product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void UpdateProduct(ProductModel product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(int productId)
        {
            var product = _context.Products.Find(productId);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }
    }
}
