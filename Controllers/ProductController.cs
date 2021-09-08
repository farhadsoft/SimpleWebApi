using System;
using Microsoft.AspNetCore.Mvc;
using SimpleWebApi.Models;
using SimpleWebApi.Repository;

namespace SimpleWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository repository;

        public ProductController(IProductRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(repository.GetAllProducts());
        }

        [HttpGet("{id:Guid}")]
        public IActionResult GetById(Guid id)
        {
            return Ok(repository.GetProductById(id));
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            product.Id = Guid.NewGuid();
            repository.Create(product);
            return Created("/", product);
        }

        [HttpDelete("{id:Guid}")]
        public IActionResult Delete(Guid id)
        {
            repository.Delete(id);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(Product product)
        {
            repository.Update(product);
            return Ok();
        }
    }
}