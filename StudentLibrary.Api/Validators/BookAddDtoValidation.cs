using FluentValidation;
using StudentLibrary.Core.Dtos;

namespace StudentLibrary.Api.Validators
{
    public class BookAddDtoValidation : AbstractValidator<BookAddDto>
    {
        public BookAddDtoValidation()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("Name field cannot be empty");
            RuleFor(x => x.IsbnNo).NotNull().WithMessage("Isbno field cannot be empty");
            RuleFor(x => x.Page).NotNull().WithMessage("Page field cannot be empty");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Namespace must be a minmum of 50 characters");            
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Namespace must be a maximum of 50 characters");
           
        }
    }
}
