using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Poke.Domain.Dto.Request;
using Poke.Domain.Interfaces.UseCases;

namespace Poke.API.Controllers
{
    [Route("api/pokemon-masters")]
    [ApiController]
    public class PokemonMastersController : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromServices] IGetPokemonMaster service, Guid id)
        {
            var result = await service.Get(id);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromServices] IPostPokemonMaster service, PokemonMasterRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await service.Execute(request);

            return Ok(result);


        }

        [HttpPost("catch-pokemon")]
        public async Task<IActionResult> PostCatchPokemon([FromServices] IPostPokemonCaught service, PokemonCaughtRequest request)
        {

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await service.Execute(request);

            return Ok();


        }
    }
}
