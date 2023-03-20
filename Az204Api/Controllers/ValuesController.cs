using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Az204Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult MostrarSaludo(string nombre)
        {
            return Ok($"Hola {nombre} ");
        }
    }
}
