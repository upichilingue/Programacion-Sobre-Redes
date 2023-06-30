using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi1.Controllers
{

    [Route("saludos")]
    [ApiController]
    public class SaludosController:ControllerBase
    {

        [HttpGet("{nombre}")]

        public ActionResult <string> Obtenersaludo(string nombre)
        {
            return $"Hola, {nombre}!";
        }

    }
}
