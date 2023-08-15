using FluentValidation;

namespace Application.Features.InvoiceFiles.Commands.Delete;

public class DeleteInvoiceFileCommandValidator : AbstractValidator<DeleteInvoiceFileCommand>
{
    public DeleteInvoiceFileCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
    }
}