using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace Json_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        public DemoController()
        {
            //Cambio 1 del usuario developer
        }

        [HttpGet("generica")]
        public IActionResult ListaGenerica()
        {
            var personas = new List<Persona>()
            {
                new Persona
                { 
                    Id = 1, 
                    Nombre = "Juan", 
                    Edad = 18 
                },
                new Persona
                {
                    Id = 2,
                    Nombre = "Maria",
                    Edad = 17
                }
            };

            return Ok(personas);

        }

        [HttpGet("diccionario")]
        public IActionResult Diccionarios()
        {
            var diccionario = new Dictionary<string, string>
            {
                { "clave1", "valor1" },
                { "clave2", "valor2" },
                { "clave3", "valor3" },
                { "clave4", "valor4" },
                { "clave5", "valor5" }
            };

            return Ok(diccionario);
        }

        [HttpGet("dinamico")]
        public IActionResult ObjetoDinamico()
        {
            List<object> lista = new List<object>();
            dynamic objDinamico = new ExpandoObject();
            objDinamico.Id = 1;
            objDinamico.Nombre = "Juan";
            objDinamico.Edad = 18;
            lista.Add(objDinamico);

            objDinamico = new ExpandoObject();
            objDinamico.Id = 1;
            objDinamico.Nombre = "Juan";
            objDinamico.Edad = 18;
            lista.Add(objDinamico);

            objDinamico = new ExpandoObject();
            objDinamico.Id = 1;
            objDinamico.Nombre = "Juan";
            objDinamico.Edad = 18;
            lista.Add(objDinamico);

            return Ok(objDinamico);
        }
    }
}
