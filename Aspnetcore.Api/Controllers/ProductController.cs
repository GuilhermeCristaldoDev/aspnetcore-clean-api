using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/products")]
public class ProductController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllProducts()
    {
        return Ok ("entremo");
    }

    [HttpPost]
    public IActionResult CreateProduct()
    {
        return Ok();
    }
}