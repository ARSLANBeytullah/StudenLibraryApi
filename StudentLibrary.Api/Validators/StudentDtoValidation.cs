using FluentValidation;
using StudentLibrary.Core.Dtos;

namespace StudentLibrary.Api.Validators
{
    public class StudentDtoValidation : AbstractValidator<StudentDto>
    {
        public StudentDtoValidation()
        {
            RuleFor(x => x.Id).NotNull().WithMessage("Id field cannot be empty");
            RuleFor(x => x.Name).NotNull().WithMessage("Name field cannot be empty");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Namespace must be a maximum of 50 characters");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Namespace must be a minmum of 50 characters");
            RuleFor(x => x.Surname).NotNull().WithMessage("Surname field cannot be empty");
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage("Namespace must be a minimum of 50 characters");
            RuleFor(x => x.Surname).MaximumLength(50).WithMessage("Namespace must be a maximum of 50 characters");
            RuleFor(x => x.StudentNo).NotNull().WithMessage("Student No field cannot be empty");
            RuleFor(x => x.Class).NotNull().WithMessage("Class field cannot be empty");
        }
    }
}
