using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlightApp.Data;
using FlightApp.Enums;
using FlightApp.Models;
using FlightApp.Models.IRepositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FlightApp.Controllers
{
    [ApiConventionType(typeof(DefaultApiConventions))]
    [Produces("application/json")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productRepository.getAll().ToList();
        }

        // GET: api/<controller>
        [HttpGet("GetBy/{category}")]
        public IEnumerable<Product> GetByCategory(Category category)
        {
            return _productRepository.getByCategory(category).ToList();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _productRepository.getById(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post(Product p)
        {
            _productRepository.Add(p);
            _productRepository.SaveChanges();
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, Product p)
        {
            _productRepository.Update(p);
            _productRepository.SaveChanges();
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Product productToRemove = _productRepository.getById(id);
            _productRepository.Delete(productToRemove);
            _productRepository.SaveChanges();
        }
    }
}
