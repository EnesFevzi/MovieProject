using AutoMapper;
using MovieProject.Core.BaseRepositories;
using MovieProject.Entity.Entities;
using MovieProject.Service.DTOs.Categories;
using MovieProject.Service.Services.Abstract;

namespace MovieProject.Service.Services.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _repository;
        private readonly IMapper _mapper;

        public CategoryService(IRepository<Category> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Category> CreateCategory(CategoryAddDto category)
        {
            var map = _mapper.Map<Category>(category);
            await _repository.AddAsync(map);
            return map;
        }

        public async Task DeleteCategory(int categoryId)
        {
            var film = await _repository.GetByIDAsync(categoryId);
            await _repository.DeleteAsync(film);
        }

        public Task<Category> GetCategoryById(int categoryId)
        {
            return _repository.GetByIDAsync(categoryId);
        }

        public async Task<List<Category>> GetCategorys()
        {
           return await _repository.GetAllAsync();
        }


        public async Task<Category> UpdateCategory(CategoryUpdateDto category)
        {
            var map = _mapper.Map<Category>(category);
            await _repository.UpdateAsync(map);
            return map;
        }
    }
}
