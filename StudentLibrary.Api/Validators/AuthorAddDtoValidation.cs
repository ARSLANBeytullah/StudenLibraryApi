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
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Namespace must be a minmum of 50 characters");
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage("Namespace must be a minimum of 50 characters");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Namespace must be a maximum of 50 characters");
            RuleFor(x => x.Surname).MaximumLength(50).WithMessage("Namespace must be a maximum of 50 characters");
        }
    }
}
