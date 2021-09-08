using System;
using System.Collections.Generic;
using SimpleWebApi.Models;

namespace SimpleWebApi.Repository
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        Product GetProductById(Guid id);
        void Create(Product product);
        void Update(Product product);
        void Delete(Guid id);
    }
}