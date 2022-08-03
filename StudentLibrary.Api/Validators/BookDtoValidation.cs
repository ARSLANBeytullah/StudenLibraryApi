using FluentValidation;
using StudentLibrary.Core.Dtos;

namespace StudentLibrary.Api.Validators
{
    public class BookDtoValidation : AbstractValidator<BookDto>
    {
        public BookDtoValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name field cannot be empty");
            RuleFor(x => x.Page).NotEmpty().WithMessage("Page field cannot be empty");
            RuleFor(x => x.IsbnNo).NotEmpty().WithMessage("IsbnNo field cannot be empty");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Namespace must be a minmum of 50 characters");          
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Namespace must be a maximum of 50 characters");         
        }
    }
}
