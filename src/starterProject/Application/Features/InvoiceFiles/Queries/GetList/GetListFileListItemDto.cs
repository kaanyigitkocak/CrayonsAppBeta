using Core.Application.Dtos;

namespace Application.Features.InvoiceFiles.Queries.GetList;

public class GetListInvoiceFileListItemDto : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string FullPath { get; set; }
    public string MimeType { get; set; }
}