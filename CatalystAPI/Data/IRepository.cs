using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalystAPI.Data
{
    public interface IRepository<T> where T : class, IEntity
    {
        Task<T> Get(long id);
        Task<List<T>> GetAll();
        Task<List<T>> SearchByName(string name);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(long id);
    }
}
