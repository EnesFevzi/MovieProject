﻿using FluentValidation;
using MovieProject.Service.DTOs.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Service.FluentValidations
{
    public class CategoryAddDtoValidator:AbstractValidator<CategoryAddDto>
    {
        public CategoryAddDtoValidator()
        {
            RuleFor(dto => dto.Name).NotEmpty().WithMessage("Name cannot be empty");
        }
    }
}
