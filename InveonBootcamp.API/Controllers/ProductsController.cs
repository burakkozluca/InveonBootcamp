using Microsoft.AspNetCore.Mvc;

namespace InveonBootcamp.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }

    [HttpGet]
    public IActionResult Get(int id)
    {
        return Ok();
    }

    [HttpPost]
    public IActionResult Create()
    {
        return Ok();
    }

    [HttpPut]
    public IActionResult Update()
    {
        return Ok();
    }

    [HttpPatch]
    public IActionResult UpdatePatch()
    {
        return Ok();
    }
    
    [HttpDelete]
    public IActionResult DeleteProduct()
    {
        return Ok();
    }

}