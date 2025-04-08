using LibraryApp.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Application.Abstract;

public interface IService<TDto, TEntity>
{
    Task<List<TDto>> GetAllAsync();
    Task<TDto> GetByIdAsync(int id);
    Task<TDto> CreateAsync(TDto dto);
    Task<bool> UpdateAsync(int id, TDto dto);
    Task<bool> DeleteAsync(int id);
}
