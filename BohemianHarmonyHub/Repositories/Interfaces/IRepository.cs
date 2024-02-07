using System.Linq.Expressions;

namespace BohemianHarmonyHub.Repository.Interfaces
{
    public interface IRepository<T>
    {
        //métodos de contrato
        IEnumerable<T> Get();
        Task<T> GetById(Expression<Func<T, bool>> predicate);
        Task Post(T entity);
        Task Put(T entity);
        Task Delete(T entity);

    }
}
