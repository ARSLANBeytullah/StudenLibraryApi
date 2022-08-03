using FluentValidation;
using StudentLibrary.Core.Dtos;

namespace StudentLibrary.Api.Validators
{
    public class StudentUpdateDtoValidation : AbstractValidator<StudentUpdateDto>
    {
        public StudentUpdateDtoValidation()
        {
            RuleFor(x => x.Id).NotNull().WithMessage("Id field can not be empty");
            RuleFor(x => x.Name).NotNull().WithMessage("Name field can not be empty");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Namespace must be a maximum of 50 characters");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Namespace must be a minimum of 2 characters");
            RuleFor(x => x.Surname).MaximumLength(50).WithMessage("Namespace must be a maximum of 50 characters");
            RuleFor(x => x.Surname).NotNull().WithMessage("Surname field can not be empty");
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage("Surnamespace must be a mibimum of 2 characters");
            RuleFor(x => x.Class).NotNull().WithMessage("Class field cannot be empty");
            RuleFor(x => x.StudentNo).NotNull().WithMessage("StudentNo field can not be empty");
        }
    }
}
    
