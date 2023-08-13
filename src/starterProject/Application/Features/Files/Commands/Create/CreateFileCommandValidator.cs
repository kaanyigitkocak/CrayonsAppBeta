using FluentValidation;

namespace Application.Features.Files.Commands.Create;

public class CreateFileCommandValidator : AbstractValidator<CreateFileCommand>
{
    public CreateFileCommandValidator()
    {
        RuleFor(c => c.FormFile).NotEmpty();
    }
}