using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Students.Commands.Create;
public class CreateStudentCommandValidator : AbstractValidator<CreateStudentCommand>
{
    public CreateStudentCommandValidator()
    {
        RuleFor(c => c.Name).NotEmpty().MinimumLength(2);
        RuleFor(c => c.DateOfBirth).NotEmpty().Must(BeAValidDate);
        RuleFor(c => c.Class).NotEmpty().MinimumLength(2);
        RuleFor(c => c.TeacherId);
        RuleFor(c => c.ParentId);
        RuleFor(c => c.SchoolId);
    }

    private bool BeAValidDate(DateTime date)
    {
        return date != default(DateTime);
    }
}