using BohemianHarmonyHub.Models;
using BohemianHarmonyHub.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BohemianHarmonyHub.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlbumsController : Controller
    {
        private readonly IAlbumRepository _albumRepository;
        public AlbumsController(IAlbumRepository albumRepository) 
        {
            _albumRepository = albumRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Album>> Get()
        {
            var albums = _albumRepository.Get().ToList();
            if (albums != null)
            {
                return Ok(albums);
            }
            return BadRequest();
        }

        [HttpGet("{id:int}", Name ="GetAlbum")]
        public ActionResult<Album> GetById(int id)
        {
            var album = _albumRepository.GetById(id);
            if (album != null)
            {
                return Ok(album);
            }

            return BadRequest();
        }

        [HttpGet("name")]
        public ActionResult<IEnumerable<Album>> GetByName([FromQuery] string name)
        {
            var album = _albumRepository.GetByName(name).ToList();
            if (album != null)
            {
                return Ok(album);
            }
            return BadRequest();
        }

        [HttpPost]
        public async Task<ActionResult<Album>> Post(Album album)
        {
            if (album != null)
            {
                await _albumRepository.Post(album);
                return new CreatedAtRouteResult("GetAlbum", new { id = album.BandId }, album);
            }

            return BadRequest();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Album>> Put(int id, Album album)
        {
            if (album.AlbumId == id)
            {
                await _albumRepository.Put(album);
                return Ok(album);
            }

            return BadRequest();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Album>> Delete(int id)
        {
            var album = _albumRepository.GetById(id);
            if ( album.AlbumId == id)
            {
                await _albumRepository.Delete(album);
                return Ok(album);
            }

            return BadRequest();
        }
    }
}
