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
        RuleFor(c => c.TeacherId).NotEmpty().GreaterThan(0);
        RuleFor(c => c.ParentId).NotEmpty().GreaterThan(0);
        RuleFor(c => c.SchoolId).NotEmpty().GreaterThan(0);
    }

    private bool BeAValidDate(DateTime date)
    {
        return date != default(DateTime);
    }
}