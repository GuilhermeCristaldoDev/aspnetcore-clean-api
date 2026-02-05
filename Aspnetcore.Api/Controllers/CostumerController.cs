
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/costumer")]
public class CostumerController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllCostumers()
    {
        return Ok("Opa, cheguei");
    }
}