using FluentValidation;

namespace Application.Features.ParentFeatures.Commands.Update;

public class UpdateParentFeatureCommandValidator : AbstractValidator<UpdateParentFeatureCommand>
{
    public UpdateParentFeatureCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.FeatureName).NotEmpty();
        RuleFor(c => c.ParentId).NotEmpty();
        RuleFor(c => c.Parent).NotEmpty();
    }
}