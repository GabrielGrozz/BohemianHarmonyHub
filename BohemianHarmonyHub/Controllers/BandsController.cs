using BohemianHarmonyHub.Models;
using BohemianHarmonyHub.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BohemianHarmonyHub.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BandsController : Controller
    {
        private readonly IBandRepository _bandRepository;
        public BandsController(IBandRepository repository)
        {
            _bandRepository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<Band>> Get()
        {
            return Ok(_bandRepository.Get());
        }

        [HttpGet("{id:int}", Name = "GetBand")]
        public async Task<ActionResult<Band>> GetById(int id)
        {
            var band = await _bandRepository.GetById(id);
            return Ok(band);
        }

        [HttpGet("name")]
        public async Task<ActionResult<Band>> GetByName([FromQuery] string name)
        {
            var band = await _bandRepository.GetByName(name);
            return Ok(band);
        }

        [HttpPost]
        public async Task<ActionResult<Band>> Post(Band band)
        {
            await _bandRepository.Post(band);
            return new CreatedAtRouteResult("GetBand", new { id = band.BandId }, band);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Band>> Put(int id, Band band)
        {
            if (band.BandId == id)
            {
                await _bandRepository.Put(band);
                return Ok("Banda modificicada com sucesso! - " + band);
            }

            return BadRequest("O valor passado é inválido!");
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Band>> Delete(int id)
        {
            var band = await _bandRepository.GetById(id);
            if (band.BandId == id)
            {
                await _bandRepository.Delete(band);
                return Ok();
            }

            return BadRequest("Não foi possível excluir a banda!");
        }
    }
}
