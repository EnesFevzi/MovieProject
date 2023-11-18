using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieProject.Service.DTOs.Categories;
using MovieProject.Service.DTOs.Films;
using MovieProject.Service.FluentValidations;
using MovieProject.Service.Services.Abstract;

namespace MovieProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCategorys()
        {
            var films = await _categoryService.GetCategorys();
            return Ok(films);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            var film = await _categoryService.GetCategoryById(id);

            if (film == null)
            {
                return NotFound();
            }

            return Ok(film);
        }

        [HttpPost("CreateCategory")]
        public async Task<IActionResult> CreateCategory(CategoryAddDto filmDTO)
        {
            var validator = new CategoryAddDtoValidator();
            var validationResult = validator.Validate(filmDTO);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            await _categoryService.CreateCategory(filmDTO);
            return Ok("Ekleme İşlemi Başarılı");
        }

        [HttpPut("UpdateCategory")]
        public async Task<IActionResult> UpdateCategory(CategoryUpdateDto filmDTO)
        {
            var validator = new CategoryUpdateDtoValidator();
            var validationResult = validator.Validate(filmDTO);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }
            var updatedCategory = await _categoryService.UpdateCategory(filmDTO);

            if (updatedCategory == null)
            {
                return NotFound();
            }
            return Ok(updatedCategory);
        }

        [HttpDelete("DeleteCategory/{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _categoryService.DeleteCategory(id);
            return Ok("silindi");
        }
    }
}
