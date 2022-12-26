using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxBeTestA.Application.Interfaces
{
    public interface IGenericRepository<TModel, TKey> 
    {
        Task<IEnumerable<TModel>> GetAll();
        Task<TModel> GetById(TKey id);
        Task<TModel> Insert(TModel entity);
        Task<TModel> Update(TModel entity);
        Task Delete(TKey id);
    }
}
