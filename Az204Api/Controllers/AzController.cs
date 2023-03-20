using Microsoft.AspNetCore.Mvc;

namespace Az204Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AzController : ControllerBase
    {
        [HttpGet]
        public IActionResult BadRequest()
        {
            return NotFound("Error no encontrado");
        }        
    }
}
