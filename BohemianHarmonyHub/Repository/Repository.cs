using BohemianHarmonyHub.Context;
using BohemianHarmonyHub.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BohemianHarmonyHub.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {

        private readonly AppDbContext _context;
        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<T> Get()
        {
            var bands = _context.Set<T>().AsNoTracking();
            return bands;
        }

        public async Task<T> GetById(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task Post(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task Put(T entity)
        {
            throw new NotImplementedException();
        }
        public async Task Delete(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
