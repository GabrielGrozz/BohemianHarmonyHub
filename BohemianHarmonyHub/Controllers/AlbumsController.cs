using BohemianHarmonyHub.Models;
using BohemianHarmonyHub.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BohemianHarmonyHub.Controllers
{
    public class AlbumsController : Controller
    {
        private readonly IAlbumRepository _albumRepository;
        public AlbumsController(IAlbumRepository albumRepository) 
        {
            _albumRepository = albumRepository;
        }

        public ActionResult<IQueryable<Album>> Get()
        {
            var albums = _albumRepository.Get();
            if (albums != null)
            {
                return Ok(albums);
            }
            return BadRequest();
        }

        public ActionResult<Album> GetById(int id)
        {
            var album = _albumRepository.GetById(id);
            if (album != null)
            {
                return Ok(album);
            }

            return BadRequest();
        }

        public ActionResult<IQueryable<Album>> GetByName(string name)
        {
            var album = _albumRepository.GetByName(name);
            if (album != null)
            {
                return Ok(album);
            }
            return BadRequest();
        }

        public async Task<ActionResult<Album>> Post(Album album)
        {
            if (album != null)
            {
                await _albumRepository.Post(album);
                return new CreatedAtRouteResult("GetAlbum", new { id = album.BandId }, album);
            }

            return BadRequest();
        }

        public async Task<ActionResult<Album>> Put(int id, Album album)
        {
            if (album.AlbumId == id)
            {
                await _albumRepository.Put(album);
                return Ok(album);
            }

            return BadRequest();
        }

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
