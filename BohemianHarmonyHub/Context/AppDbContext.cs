using BohemianHarmonyHub.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BohemianHarmonyHub.Context
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> op ) : base(op)  {   }

        public DbSet<Band>? bands {  get; set; }
        public DbSet<Album>? albums { get; set; }
        public DbSet<BandMember>? bandMembers { get; set; }

    }
}
