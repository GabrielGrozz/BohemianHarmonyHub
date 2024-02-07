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

        public async Task<Band> GetById(int id)
        {
            var band = await Get().FirstOrDefaultAsync(res => res.BandId == id);
            return band;
        }

        public IEnumerable<Band> GetByName(string name)
        {
            var bands = Get().Where(res => res.Name.Contains(name));
            return bands;
        }
    }
}
