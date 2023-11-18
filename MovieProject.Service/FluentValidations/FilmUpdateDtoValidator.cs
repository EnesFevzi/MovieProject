using FluentValidation;
using MovieProject.Service.DTOs.Films;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Service.FluentValidations
{
    public class FilmUpdateDtoValidator:AbstractValidator<FilmUpdateDto>
    {
        public FilmUpdateDtoValidator()
        {
            RuleFor(dto => dto.Title).NotEmpty().WithMessage("Title cannot be empty");
            RuleFor(dto => dto.ReleaseDate).NotEmpty().WithMessage("ReleaseDate cannot be empty");
            RuleFor(dto => dto.CategoryId).NotEmpty().WithMessage("CategoryId cannot be empty");
            RuleFor(dto => dto.ActorId).NotNull().NotEmpty().WithMessage("ActorId cannot be empty");
        }
    }
}
