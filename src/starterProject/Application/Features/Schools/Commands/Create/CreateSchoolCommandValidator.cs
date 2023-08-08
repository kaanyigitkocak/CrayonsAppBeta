using FluentValidation;

namespace Application.Features.Schools.Commands.Create;

public class CreateSchoolCommandValidator : AbstractValidator<CreateSchoolCommand>
{
    public CreateSchoolCommandValidator()
    {
        RuleFor(c => c.Name).NotEmpty();
        RuleFor(c => c.Address).NotEmpty();
        RuleFor(c => c.PhoneNumber).NotEmpty();
    }
}