using System.Threading.Tasks;
using Domain.Commands.Handlers;
using Domain.Commands.Inputs;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class OngController : Controller
    {
        public OngController(OngHandler handler)
        {
            _handler = handler;
        }

        private readonly OngHandler _handler;

        [HttpPost]
        [Route("ongs")]
        public async Task<IActionResult> Post([FromBody] OngInputCommand command)
        {
            var result = _handler.Handler(command);
            return await Retorno(result);
        }

        private async Task<IActionResult> Retorno(object result)
        {
            return Ok(new
            {
                data = result
            });
        }

    }
}