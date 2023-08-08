using FluentValidation;

namespace Application.Features.ParentFeatures.Commands.Delete;

public class DeleteParentFeatureCommandValidator : AbstractValidator<DeleteParentFeatureCommand>
{
    public DeleteParentFeatureCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
    }
}