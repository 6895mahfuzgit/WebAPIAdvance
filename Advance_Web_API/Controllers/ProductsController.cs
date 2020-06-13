using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Advance_Web_API.Controllers
{
    [Route("api/products")] //for Core 3
    //[RouterPrefix(api/products)] for mvc 5
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET: api/Product
        [HttpGet]
        public IEnumerable<string> GetAllProducts()
        {
            return new string[] { "Product 1", "Product 2" };
        }

        // GET: api/Product/5
        [HttpGet("{id:int:range(1,5)}")]
        public string GetProductById(int id)
        {
            return "from int vale Id";
        }

       

        // POST: api/Product
        [HttpPost]
        public void CreateProduct([FromBody] string value)
        {
        }

        // PUT: api/Product/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
