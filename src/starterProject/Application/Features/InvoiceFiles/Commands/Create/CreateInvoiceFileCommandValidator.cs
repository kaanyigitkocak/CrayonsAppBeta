using FluentValidation;

namespace Application.Features.InvoiceFiles.Commands.Create;

public class CreateInvoiceFileCommandValidator : AbstractValidator<CreateInvoiceFileCommand>
{
    public CreateInvoiceFileCommandValidator()
    {
    }
}