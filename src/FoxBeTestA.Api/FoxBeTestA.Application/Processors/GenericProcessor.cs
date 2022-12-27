using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FoxBeTestA.Application.Interfaces;
using FoxBeTestA.DAL.Models;

namespace FoxBeTestA.Application.Processors
{
    public class GenericProcessor<TModel, TDto, TKey>  : IGenericProcessor<TModel, TDto, TKey>
    {
        private readonly IGenericRepository<TModel, TKey> _genericRepository;
        private readonly IMapper _mapper;

        public GenericProcessor(IGenericRepository<TModel, TKey> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TDto>> ExecuteGetAll()
        {
            return _mapper.Map<IEnumerable<TDto>>(await _genericRepository.GetAll());
        }

        public async Task<TDto> ExecuteGetById(TKey id)
        {
            return _mapper.Map<TDto>(await _genericRepository.GetById(id));
        }

        public virtual async Task<TDto> ExecuteInsert(TModel entity)
        {
            var entityDto = _mapper.Map<TDto>(await _genericRepository.Insert(entity));
            return entityDto;
        }

        public virtual async Task<TDto> ExecuteUpdate(TKey id, TModel entity)
        {
            var entityDto = _mapper.Map<TDto>(await _genericRepository.Update(entity));
            return entityDto;
        }

        public virtual async Task<bool> ExecuteDelete(TKey id)
        {
            await _genericRepository.Delete(id);
            return true;
        }
    }
}
