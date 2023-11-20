using FluentValidation;
using MovieProject.Entity.Entities;
using MovieProject.Service.DTOs.Films;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Service.FluentValidations
{
    public class FilmAddDtoValidator:AbstractValidator<FilmAddDto>
    {
        public FilmAddDtoValidator()
        {
            RuleFor(dto => dto.Title).NotEmpty().WithMessage("Title cannot be empty");
            RuleFor(dto => dto.ReleaseDate).NotEmpty().WithMessage("ReleaseDate cannot be empty");
            RuleFor(dto => dto.CategoryId).NotEmpty().WithMessage("CategoryId cannot be empty");
        }
    }
}
