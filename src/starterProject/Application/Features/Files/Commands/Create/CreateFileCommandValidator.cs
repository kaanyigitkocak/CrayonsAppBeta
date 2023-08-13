using FluentValidation;

namespace Application.Features.Files.Commands.Create;

public class CreateFileCommandValidator : AbstractValidator<CreateFileCommand>
{
    public CreateFileCommandValidator()
    {
        RuleFor(c => c.Name).NotEmpty();
        RuleFor(c => c.FullPath).NotEmpty();
        RuleFor(c => c.MimeType).NotEmpty();
    }
}