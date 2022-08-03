using FluentValidation;
using StudentLibrary.Core.Dtos;

namespace StudentLibrary.Api.Validators
{
    public class AuthorDtoValidation : AbstractValidator<AuthorDto>
    {
        public AuthorDtoValidation()
        {
            RuleFor(x => x.Id).NotNull().WithMessage("Id field cannot be empty");
            RuleFor(x => x.Name).NotNull().WithMessage("Name field cannot be empty");
            RuleFor(x => x.Surname).NotNull().WithMessage("Surname field cannot be empty");
        }
    }
}
