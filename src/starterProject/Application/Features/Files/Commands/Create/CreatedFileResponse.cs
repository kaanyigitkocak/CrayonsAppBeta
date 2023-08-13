using Core.Application.Responses;

namespace Application.Features.Files.Commands.Create;

public class CreatedFileResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string FullPath { get; set; }
    public string MimeType { get; set; }
}