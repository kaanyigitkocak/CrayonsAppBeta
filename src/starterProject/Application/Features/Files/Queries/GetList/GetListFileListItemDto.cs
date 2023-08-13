using Core.Application.Dtos;

namespace Application.Features.Files.Queries.GetList;

public class GetListFileListItemDto : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string FullPath { get; set; }
    public string MimeType { get; set; }
}