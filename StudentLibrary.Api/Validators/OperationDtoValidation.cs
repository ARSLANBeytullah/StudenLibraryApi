using FluentValidation;
using StudentLibrary.Core.Dtos;

namespace StudentLibrary.Api.Validators
{
    public class OperationDtoValidation:AbstractValidator<OperationDto>
    {
        public OperationDtoValidation()
        {
            RuleFor(x => x.Book).NotNull().WithMessage("Book field can not be empty");
            RuleFor(x => x.Student).NotNull().WithMessage("Student field can not be empty");
            RuleFor(x => x.GDate).NotNull().WithMessage("Issuanca date field should not be empty"); //Veriliş tarihi boş geçilmemelidir. GDate = veriliş tarihi
            RuleFor(x => x.TDate).NotNull().WithMessage("Receipt Date field should not be empty");  //TDate = Take Date olarak da tutulabiliridi yani alınış tarihi.
        }
    }
}
