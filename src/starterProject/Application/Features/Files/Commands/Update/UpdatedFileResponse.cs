using Core.Application.Responses;

namespace Application.Features.Files.Commands.Update;

public class UpdatedFileResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string FullPath { get; set; }
    public string MimeType { get; set; }
}