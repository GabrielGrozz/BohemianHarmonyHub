using BohemianHarmonyHub.Context;
using BohemianHarmonyHub.Models;
using BohemianHarmonyHub.Repository;
using BohemianHarmonyHub.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BohemianHarmonyHub.Repositories
{
    public class BandRepository : Repository<Band>, IBandRepository
    {
        public BandRepository(AppDbContext context) : base(context)
        {
        }

        public IEnumerable<Band> GetBandAlbumsAndMembers()
        {
            var bands = Get().Include(res => res.BandMembers).Include(res => res.Discography).ToList();
            return bands;
        }

        public Band GetById(int id)
        {
            var band = Get().FirstOrDefault(res => res.BandId == id);
            return band;
        }

        public IQueryable<Band> GetByName(string name)
        {
            var bands = Get().Where(res => res.Name.Contains(name));
            return bands;
        }
    }
}
