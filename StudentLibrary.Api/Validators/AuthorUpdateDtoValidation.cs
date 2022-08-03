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
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Namespace must be a minmum of 50 characters");
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage("Namespace must be a minimum of 50 characters");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Namespace must be a maximum of 50 characters");
            RuleFor(x => x.Surname).MaximumLength(50).WithMessage("Namespace must be a maximum of 50 characters");
        }
    }
}
