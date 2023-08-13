using Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Application.Features.Files.Queries.GetById;

public class GetByIdFileResponse : IResponse
{
    public FileResult Result { get; set; }
}