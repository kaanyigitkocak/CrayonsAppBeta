using FluentValidation;

namespace Application.Features.Files.Commands.Update;

public class UpdateFileCommandValidator : AbstractValidator<UpdateFileCommand>
{
    public UpdateFileCommandValidator()
    {
        RuleFor(c => c.FullPath).NotEmpty();
        RuleFor(c => c.File);
    }
}