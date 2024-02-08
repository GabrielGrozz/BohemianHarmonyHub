using BohemianHarmonyHub.Context;
using BohemianHarmonyHub.Models;
using BohemianHarmonyHub.Repositories.Interfaces;
using BohemianHarmonyHub.Repository;

namespace BohemianHarmonyHub.Repositories
{
    public class AlbumRepository : Repository<Album>, IAlbumRepository
    {
        public AlbumRepository(AppDbContext context) : base(context) { }
        public Album GetById(int id)
        {
            var album = Get().FirstOrDefault(res => res.BandId == id);
            return album;
        }

        public IQueryable<Album> GetByName(string name)
        {
            var albums = Get().Where(res => res.Title.Contains(name));
            return albums;
        }
    }
}
