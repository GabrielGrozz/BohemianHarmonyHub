using BohemianHarmonyHub.Models;

namespace BohemianHarmonyHub.Repository.Interfaces
{
    public interface IBandRepository : IRepository<Band>
    {
        Task<Band> GetById(int id);
        Task<IEnumerable<Band>> GetByName(string name);
    }
}
