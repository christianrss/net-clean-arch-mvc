using NetCleanArchMvc.Application.DTOs;
using NetCleanArchMvc.Domain.Entities;

namespace NetCleanArchMvc.Application.Interfaces;

public interface ICategoryService
{
    Task<IEnumerable<CategoryDTO>> GetCategories();
    Task<CategoryDTO> GetById(int? id);
    Task Add(Category categoryDto);
    Task Update(CategoryDTO categoryDto);
    Task Remove(int? id);
}
