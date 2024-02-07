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

        public IEnumerable<T> Get()
        {
            var bands = _context.Set<T>().AsNoTracking();
            return bands;
        }

        public async Task<T> GetById(Expression<Func<T, bool>> predicate)
        {
            var band = await _context.Set<T>().FirstOrDefaultAsync(predicate);
            return band;
        }

        public async Task Post(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Put(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task Delete(T entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
