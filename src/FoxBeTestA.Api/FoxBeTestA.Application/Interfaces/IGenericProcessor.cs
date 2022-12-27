using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxBeTestA.Application.Interfaces
{
    public interface IGenericProcessor<TModel, TDto, TKey>
    {
        public Task<IEnumerable<TModel>> ExecuteGetAll();
        public Task<IEnumerable<TDto>> ExecuteGetAllToDto();
        public Task<TModel> ExecuteGetById(TKey id);
        public Task<TDto> ExecuteGetByIdToDto(TKey id);
        public Task<TModel> ExecuteInsert(TModel entity);
        public Task<TDto> ExecuteInsertToDto(TModel entity);
        public Task<TModel> ExecuteUpdate(TKey id, TModel entityDto);
        public Task<TDto> ExecuteUpdateToDto(TKey id, TModel entityDto);
        public Task<bool> ExecuteDelete(TKey id);
    }
}
