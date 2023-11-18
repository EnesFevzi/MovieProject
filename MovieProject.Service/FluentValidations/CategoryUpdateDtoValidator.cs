using FluentValidation;
using MovieProject.Service.DTOs.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Service.FluentValidations
{
    public class CategoryUpdateDtoValidator:AbstractValidator<CategoryUpdateDto>
    {
        public CategoryUpdateDtoValidator()
        {
            RuleFor(dto => dto.Name).NotEmpty().WithMessage("Name cannot be empty");
        }
    }
}
