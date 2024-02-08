using BohemianHarmonyHub.Models;
using BohemianHarmonyHub.Repository.Interfaces;

namespace BohemianHarmonyHub.Repositories.Interfaces
{
    public interface IAlbumRepository : IRepository<Album>
    {
        Album GetById(int id);
        IQueryable<Album> GetByName(string name);
    }
}
