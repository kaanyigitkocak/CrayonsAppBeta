using Application.Features.InvoiceFiles.Commands.Create;
using Application.Features.InvoiceFiles.Commands.Delete;
using Application.Features.InvoiceFiles.Commands.Update;
using Application.Features.InvoiceFiles.Queries.GetById;
using AutoMapper;
using Core.Application.Responses;

using Core.Persistence.Paging;
using File = Domain.Entities.File;
using Domain.Entities;

namespace Application.Features.InvoiceFiles.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<InvoiceFile, CreateInvoiceFileCommand>().ReverseMap();
        CreateMap<InvoiceFile, CreatedInvoiceFileResponse>().ReverseMap();
        CreateMap<InvoiceFile, UpdateInvoiceFileCommand>().ReverseMap();
        CreateMap<InvoiceFile, UpdatedInvoiceFileResponse>().ReverseMap();
        CreateMap<InvoiceFile, DeleteInvoiceFileCommand>().ReverseMap();
        CreateMap<InvoiceFile, DeletedInvoiceFileResponse>().ReverseMap();
        CreateMap<InvoiceFile, GetByIdInvoiceFileResponse>().ReverseMap();
    }
}