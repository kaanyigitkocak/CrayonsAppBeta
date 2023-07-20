using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Requests;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Students.Queries.GetList;
public class GetListStudentQuery : IRequest<GetListResponse<GetListStudentListItemResponse>>
{
    public PageRequest PageRequest { get; set; }

    public GetListStudentQuery()
    {
        PageRequest = new PageRequest { PageIndex = 0, PageSize = 10 };
    }

    public GetListStudentQuery(PageRequest pageRequest)
    {
        PageRequest = pageRequest.PageSize == 0 && pageRequest.PageIndex == 0
        ? new PageRequest { PageIndex = 0, PageSize = 10 }
        : pageRequest;
    }

    public class GetListStudentQueryHandler : IRequestHandler<GetListStudentQuery, GetListResponse<GetListStudentListItemResponse>>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public GetListStudentQueryHandler(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListStudentListItemResponse>> Handle(GetListStudentQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Student> students = await _studentRepository.GetListAsync(
                index: request.PageRequest.PageIndex,
                size: request.PageRequest.PageSize,
                include: s => s.Include(s => s.Parent!)
                               .Include(s => s.School!)
                               .Include(s => s.Teacher!),
                cancellationToken: cancellationToken
            );

            GetListResponse<GetListStudentListItemResponse> response = _mapper.Map<GetListResponse<GetListStudentListItemResponse>>(students);
            return response;
        }
    }
}