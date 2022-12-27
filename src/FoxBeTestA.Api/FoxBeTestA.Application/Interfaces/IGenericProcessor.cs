using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxBeTestA.Application.Interfaces
{
    public interface IGenericProcessor<TModel, TDto, TKey>
    {
        public Task<IEnumerable<TDto>> ExecuteGetAll();
        public Task<TDto> ExecuteGetById(TKey id);

        public Task<TDto> ExecuteInsert(TModel entity);
        public Task<TDto> ExecuteUpdate(TKey id, TModel entityDto);
        public Task<bool> ExecuteDelete(TKey id);
    }
}
