using Microsoft.AspNetCore.Mvc;

namespace SL.Controllers
{
    public class VueloController : Controller
    {
        [HttpPost ("GetAll")]
        public IActionResult GetAll(string FechaInicio, string FechaFin)
        {

            ML.Vuelo vuelo = new ML.Vuelo ();

            vuelo.FechaInicio = FechaInicio;
            vuelo.FechaFin= FechaFin;

            ML.Result result = BL.Vuelo.GetAll(vuelo);

            if (result.Correct)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest (result);
            }
        }
    }
}
