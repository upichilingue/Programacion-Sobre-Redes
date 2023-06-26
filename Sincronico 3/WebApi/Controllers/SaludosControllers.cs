using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("Saludos")]
    [ApiController]

    public class SaludosControllers: ControllerBase
    {

        [HttpGet("{nombre}")]
        public ActionResult<string> ObtenerSalud(string nombre)
        {
            return $"Hola, {nombre}!";
        }

    }
}
