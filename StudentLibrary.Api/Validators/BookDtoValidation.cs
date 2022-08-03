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
        }
    }
}
