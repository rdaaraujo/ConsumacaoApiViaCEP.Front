using BrasilAPI.Business.Control;
using BrasilAPI.Models.API.Saida;
using BrasilAPI.Models.Enums;
using BrasilAPI.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace BrasilAPI.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BrasilAPIController : ControllerBase
    {
        [HttpGet("Localizacao")]
        public IActionResult BuscaLocalizacao()
        {
            try
            {
                var _fluixoApiControl = new FluxoApiControl();

                var result = _fluixoApiControl.ProcessaDados(MetodoAPI.cidade, "", new LocalidadeSaida());

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
    }
}