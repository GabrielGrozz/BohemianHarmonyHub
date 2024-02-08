using BohemianHarmonyHub.Models;
using BohemianHarmonyHub.Repository.Interfaces;

namespace BohemianHarmonyHub.Repositories.Interfaces
{
    public interface IBandMemberRepository : IRepository<BandMember>
    {
        public IQueryable<BandMember> GetByName(string name);

        public BandMember GetById(int id);
    }
}
