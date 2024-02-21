using BohemianHarmonyHub.Models;
using BohemianHarmonyHub.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public ActionResult<Band> Get()
        {
            var bands = _bandRepository.Get();
            if (bands != null) 
            {
                return Ok(bands);                
            }

            return BadRequest();
        }

        [HttpGet("{id:int}", Name = "GetBand")]
        public ActionResult<Band> GetById(int id)
        {
            var band = _bandRepository.GetById(id);
            if (band != null)
            {
                return Ok(band);
            }

            return NotFound();
        }

        [HttpGet("name")]
        public ActionResult<Band> GetByName([FromQuery] string name)
        {
            var band =  _bandRepository.GetByName(name);
            if (band != null)
            {
                return Ok(band);
            }

            return NotFound();
        }

        [HttpGet("details")]
        public ActionResult<IEnumerable<Band>> GetBandAlbumsAndMembers() 
        {
            var bands = _bandRepository.GetBandAlbumsAndMembers();            
            return Ok(bands);
        }

        [HttpGet("details/{id:int}")]
        public ActionResult<IEnumerable<Band>> GetByIdBandAlbumsAndMembers(int id)
        {
            var band = _bandRepository.GetBandAlbumsAndMembers().FirstOrDefault(res => res.BandId == id);
            return Ok(band);
        }

        [HttpPost]
        public async Task<ActionResult<Band>> Post(Band band)
        {
            if (band != null)
            {
                if(band.Name == "String" || band.Name == "string")
                {
                    return BadRequest("o nome String não é válido");
                }
                await _bandRepository.Post(band);
                return new CreatedAtRouteResult("GetBand", new { id = band.BandId }, band);
            }

            return BadRequest();
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
            var band = _bandRepository.GetById(id);
            if (band.BandId == id)
            {
                await _bandRepository.Delete(band);
                return Ok();
            }

            return BadRequest("Não foi possível excluir a banda!");
        }
    }
}
