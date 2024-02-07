using System.Linq.Expressions;

namespace BohemianHarmonyHub.Repository.Interfaces
{
    public interface IRepository<T>
    {
        //métodos de contrato
        IQueryable<T> Get();
        Task Post(T entity);
        Task Put(T entity);
        Task Delete(T entity);

    }
}
