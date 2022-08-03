using FluentValidation;
using StudentLibrary.Core.Dtos;

namespace StudentLibrary.Api.Validators
{
    public class AuthorAddDtoValidation : AbstractValidator<AuthorAddDto>
    {
        public AuthorAddDtoValidation()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("Name field cannot be empty");
            RuleFor(x => x.Surname).NotNull().WithMessage("Surname field cannot be empty");
        }
    }
}
