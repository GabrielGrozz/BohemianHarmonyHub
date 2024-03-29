﻿using BohemianHarmonyHub.Models;

namespace BohemianHarmonyHub.Repository.Interfaces
{
    public interface IBandRepository : IRepository<Band>
    {
        IEnumerable<Band> GetBandAlbumsAndMembers();
        Band GetById(int id);
        IQueryable<Band> GetByName(string name);
    }
}
