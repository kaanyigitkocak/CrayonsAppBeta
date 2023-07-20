using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Students.Commands.Update;
public class UpdateStudentCommandValidator : AbstractValidator<UpdateStudentCommand>
{
    public UpdateStudentCommandValidator()
    {
        RuleFor(c => c.Name).NotEmpty().MinimumLength(2);
        RuleFor(c => c.DateOfBirth).NotEmpty().Must(BeAValidDate);
        RuleFor(c => c.Class).NotEmpty().MinimumLength(2);
        RuleFor(c => c.TeacherId).NotEmpty();
        RuleFor(c => c.ParentId).NotEmpty();
        RuleFor(c => c.SchoolId).NotEmpty();
    }

    private bool BeAValidDate(DateTime date)
    {
        return date != default(DateTime);
    }
}