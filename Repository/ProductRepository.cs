using System;
using System.Collections.Generic;
using System.Linq;
using SimpleWebApi.Models;

namespace SimpleWebApi.Repository
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products = new();

        public void Create(Product product)
        {
            if (product is null)
            {
                return;
            }

            products.Add(product);
        }

        public void Delete(Guid id)
        {
            var item = products.Single(x => x.Id == id);
            products.Remove(item);
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public Product GetProductById(Guid id)
        {
            return products.Where(x => x.Id == id).FirstOrDefault();
        }

        public void Update(Product product)
        {
            products.Where(x => x.Id == product.Id)
                    .Select(x => { x.Name = product.Name; return x; })
                    .ToList();
        }
    }
}