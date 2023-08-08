using FluentValidation;

namespace Application.Features.ParentFeatures.Commands.Create;

public class CreateParentFeatureCommandValidator : AbstractValidator<CreateParentFeatureCommand>
{
    public CreateParentFeatureCommandValidator()
    {
        RuleFor(c => c.FeatureName).NotEmpty();
        RuleFor(c => c.ParentId).NotEmpty();
    }
}