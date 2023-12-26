using Bussines.Abstract;
using Entites.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public IActionResult add(Products products)
        {
            _productService.add(products);
            return Ok(products);
        }

        [HttpPut]
        public IActionResult update(Products products)
        {
            _productService.update(products);
            return Ok(products);
        }

        [HttpDelete]
        public IActionResult delete(Products products)
        {
            _productService.delete(products);
            return Ok(products);
        }

        [HttpGet]
        public IActionResult getAll()
        {
           var result = _productService.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult get(int id)
        {
            var result = _productService.Get(id);
            return Ok(result);
        }

    }
}
