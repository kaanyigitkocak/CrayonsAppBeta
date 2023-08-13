using Core.Application.Responses;

namespace Application.Features.Files.Queries.GetById;

public class GetByIdFileResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string FullPath { get; set; }
    public string MimeType { get; set; }
}