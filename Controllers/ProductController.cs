using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using microservices_rabbit.Data.ValueObjects;
using microservices_rabbit.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace microservices_rabbit.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {

        private IProductRepository _repo;

        public ProductController(IProductRepository repo)
        {
            _repo = repo;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDTO>> Get(int id)
        {
            var product = await _repo.FindById(id);
            if (product is null) return NotFound();
            return Ok(product);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetAll()
        {
            var product = await _repo.FindAll();
            if (!product.Any()) return NotFound();
            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<ProductDTO>> Create(ProductDTO product)
        {
            if (product is null) return BadRequest();
            var result = await _repo.Create(product);
            return Ok(product);
        }

        [HttpPut]
        public async Task<ActionResult<ProductDTO>> Update(ProductDTO product)
        {
            if (product is null) return BadRequest();
            var result = await _repo.Update(product);
            return Ok(product);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _repo.Delete(id);
            if (!result) return NotFound();
            return Ok();
        }
    }
}

