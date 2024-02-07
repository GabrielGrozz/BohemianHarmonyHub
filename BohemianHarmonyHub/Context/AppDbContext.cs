using BohemianHarmonyHub.Models;
using Microsoft.EntityFrameworkCore;

namespace BohemianHarmonyHub.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> op ) : base(op)  {   }

        DbSet<Band>? bands {  get; set; }
        DbSet<Album>? albums { get; set; }
        DbSet<BandMember>? bandMembers { get; set; }

    }
}
