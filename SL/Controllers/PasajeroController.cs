using Microsoft.AspNetCore.Mvc;

namespace SL.Controllers
{
    public class PasajeroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost ("Add")]
        public IActionResult Add([FromBody] ML.Pasajero pasajero)
        {
            ML.Result result=BL.Pasajero.Add(pasajero);
            if (result.Correct)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

    }
}
