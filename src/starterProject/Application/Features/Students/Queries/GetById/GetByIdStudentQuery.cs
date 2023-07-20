using Application.Features.Students.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Students.Queries.GetById;
public class GetByIdStudentQuery : IRequest<GetByIdStudentResponse>
{
    public int Id { get; set; }

    public class GetByIdStudentQueryHandler : IRequestHandler<GetByIdStudentQuery, GetByIdStudentResponse>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;
        private readonly StudentBusinessRules _studentBusinessRules;

        public GetByIdStudentQueryHandler(IStudentRepository studentRepository, IMapper mapper, StudentBusinessRules studentBusinessRules)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
            _studentBusinessRules = studentBusinessRules;
        }

        public async Task<GetByIdStudentResponse> Handle(GetByIdStudentQuery request, CancellationToken cancellationToken)
        {
            Student? student = await _studentRepository.GetAsync(predicate: s => s.Id == request.Id
            , include : s=> s.Include(s => s.School!).Include(s => s.Parent!).Include(s => s.Teacher!)
            , cancellationToken: cancellationToken);

            GetByIdStudentResponse response = _mapper.Map<GetByIdStudentResponse>(student);
            return response;
        }
    }
}