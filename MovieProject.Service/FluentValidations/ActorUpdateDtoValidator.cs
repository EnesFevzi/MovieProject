using FluentValidation;
using MovieProject.Service.DTOs.Actors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Service.FluentValidations
{
    public class ActorUpdateDtoValidator : AbstractValidator<ActorUpdateDto>
    {
        public ActorUpdateDtoValidator()
        {
            RuleFor(dto => dto.Name).NotEmpty().WithMessage("Name cannot be empty");
        }
    }
}
