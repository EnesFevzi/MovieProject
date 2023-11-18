using MovieProject.Entity.Entities;
using MovieProject.Service.DTOs.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Service.Services.Abstract
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategorys();
        Task<Category> GetCategoryById(int categoryId);
        Task<Category> CreateCategory(CategoryAddDto category);
        Task<Category> UpdateCategory(CategoryUpdateDto category);
        Task DeleteCategory(int categoryId);
    }
}
