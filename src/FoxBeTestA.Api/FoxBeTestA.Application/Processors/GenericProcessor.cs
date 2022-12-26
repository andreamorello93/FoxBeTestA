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

        public async Task<TModel> ExecuteInsert(TModel entity)
        {
            await _genericRepository.Insert(entity);
            return entity;
        }

        public async Task<TModel> ExecuteUpdate(TKey id, TModel entity)
        {
            await _genericRepository.Update(entity);
            return entity;
        }

        public async Task<bool> ExecuteDelete(TKey id)
        {
            await _genericRepository.Delete(id);
            return true;
        }
    }
}
