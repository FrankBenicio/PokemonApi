using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Poke.Domain.Interfaces.UseCases;

namespace Poke.API.Controllers
{
    [Route("api/pokemons")]
    [ApiController]
    public class PokemonsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll([FromServices] IGetPokemons service, int offset = 0)
        {
            var result = await service.Get(offset);

            return Ok(result);
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> Get([FromServices] IGetPokemon service, string name)
        {
            var result = await service.Get(name);

            return Ok(result);
        }
    }
}
