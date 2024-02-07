using BohemianHarmonyHub.Models;

namespace BohemianHarmonyHub.Repository.Interfaces
{
    public interface IBandRepository : IRepository<Band>
    {
        Task<IEnumerable<Band>> GetByName(string name);
    }
}
