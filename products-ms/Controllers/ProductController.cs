using Microsoft.AspNetCore.Mvc;

namespace products_ms.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(new { mensaje = "Lista de productos." });
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            return Ok(new { mensaje = $"Detalle del producto con ID = {id}" });
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody] string value)
        {
            return Ok(new { mensaje = $"Producto creado: {value}" });
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] string value)
        {
            return Ok(new { mensaje = $"Producto con ID = {id} actualizado a: {value}" });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            return Ok(new { mensaje = $"Producto con ID = {id} eliminado" });
        }
    }
}
