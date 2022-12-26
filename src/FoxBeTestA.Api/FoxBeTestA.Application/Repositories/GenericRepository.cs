using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoxBeTestA.Application.Interfaces;
using FoxBeTestA.DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FoxBeTestA.Application.Repositories
{
    public class GenericRepository<TModel, TKey> : IGenericRepository<TModel, TKey> where TModel : class
    {
        private FoxBeTestAContext _context;
        private DbSet<TModel> _table;

        public GenericRepository(FoxBeTestAContext context)
        {
            _context = context;
            _table = _context.Set<TModel>();
        }

        public async Task<IEnumerable<TModel>> GetAll()
        {
            return await _table.ToListAsync();
        }

        public async Task<TModel> GetById(TKey id)
        {
            return await _table.FindAsync(id);
        }

        public async Task<TModel> Insert(TModel entity)
        {
            await _table.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TModel> Update(TModel entity)
        {
            _table.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(TKey id)
        {
            var entity = await GetById(id);
            _table.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
