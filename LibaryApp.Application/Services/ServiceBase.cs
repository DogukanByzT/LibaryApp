using AutoMapper;
using LibraryApp.Application.Abstract;
using LibraryApp.Domain.Abstract;
using LibraryApp.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Application.Services
{
    public class ServiceBase<TDto, TEntity> : IService<TDto, TEntity>
        where TEntity : class
        where TDto : class
    {
        public readonly AppDbContext _context;
        public readonly IMapper _mapper;
        public readonly DbSet<TEntity> _DbSet;

        public ServiceBase(AppDbContext context, IMapper mapper )
        {
            _context = context;
            _mapper = mapper;
            _DbSet = _context.Set<TEntity>();
        }

        public async Task<List<TDto>> GetAllAsync()
            => _mapper.Map<List<TDto>>(await _DbSet.ToListAsync());

        public async Task<TDto> GetByIdAsync()
            =>_mapper.Map<TDto>(await _DbSet.FindAsync());

        public async Task<TDto> CreateAsync(TDto dto)
        {
           
            var entity = _mapper.Map<TEntity>(dto);
            _DbSet.Add(entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<TDto>(entity);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _DbSet.FindAsync(id);
            if (entity == null) { 
            return false;
            }
            _DbSet.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<bool> UpdateAsync(int id, TDto dto)
        {
            var entity = await _DbSet.FindAsync(id);
            if (entity == null) {
                return false;
            }
            _mapper.Map(dto, entity);
            await _context.SaveChangesAsync();
            return true;
        }

        public Task<TDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
