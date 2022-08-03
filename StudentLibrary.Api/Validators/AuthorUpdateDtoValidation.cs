using FluentValidation;
using StudentLibrary.Core.Dtos;

namespace StudentLibrary.Api.Validators
{
    public class AuthorUpdateDtoValidation : AbstractValidator<AuthorUpdateDto>
    {
        public AuthorUpdateDtoValidation()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id field cannot be empty");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name field cannot be empty");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Surname field cannot be empty");
        }
    }
}
