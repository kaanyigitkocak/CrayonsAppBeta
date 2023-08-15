using Application.Features.InvoiceFiles.Commands.Update;
using FluentValidation;

namespace Application.Features.InvoiceFiles.Commands.Update;

public class UpdateInvoiceFileCommandValidator : AbstractValidator<UpdateInvoiceFileCommand>
{
    public UpdateInvoiceFileCommandValidator()
    {

    }
}