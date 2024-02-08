using BohemianHarmonyHub.Context;
using BohemianHarmonyHub.Models;
using BohemianHarmonyHub.Repositories.Interfaces;
using BohemianHarmonyHub.Repository;
using BohemianHarmonyHub.Repository.Interfaces;

namespace BohemianHarmonyHub.Repositories
{
    public class BandMemberRepository : Repository<BandMember>, IBandMemberRepository
    {
        public BandMemberRepository(AppDbContext context) : base(context) 
        {

        }

        public BandMember GetById(int id)
        {
            var band = Get().FirstOrDefault(res => res.BandMemberId == id);
            return band;
        }

        public IQueryable<BandMember> GetByName(string name)
        {
            var bands = Get().Where(res => res.Name.Contains(name));
            return bands;
        }
    }
}
