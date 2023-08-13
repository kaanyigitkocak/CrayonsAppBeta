using FluentValidation;

namespace Application.Features.Invoices.Commands.Create;

public class CreateInvoiceCommandValidator : AbstractValidator<CreateInvoiceCommand>
{
    public CreateInvoiceCommandValidator()
    {
        RuleFor(c => c.InvoiceNumber).NotEmpty();
        RuleFor(c => c.Detail).NotEmpty();
        RuleFor(c => c.Amount).NotEmpty();
        RuleFor(c => c.IsPaid).NotEmpty();
        RuleFor(c => c.DueDate).NotEmpty();
        RuleFor(c => c.ParentId).NotEmpty();
        RuleFor(c => c.FileId);
    }
}