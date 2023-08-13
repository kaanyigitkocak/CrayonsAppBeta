using Core.Application.Responses;

namespace Application.Features.Invoices.Queries.GetById;

public class GetByIdInvoiceResponse : IResponse
{
    public int Id { get; set; }
    public string InvoiceNumber { get; set; }
    public string Detail { get; set; }
    public decimal Amount { get; set; }
    public bool IsPaid { get; set; }
    public DateTime DueDate { get; set; }
    public int ParentId { get; set; }
    public int FileId { get; set; }
}