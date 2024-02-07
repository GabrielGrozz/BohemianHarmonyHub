using BohemianHarmonyHub.Models;
using Microsoft.EntityFrameworkCore;

namespace BohemianHarmonyHub.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> op ) : base(op)  {   }

        public DbSet<Band>? bands {  get; set; }
        public DbSet<Album>? albums { get; set; }
        public DbSet<BandMember>? bandMembers { get; set; }

    }
}
