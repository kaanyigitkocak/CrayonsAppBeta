using Application.Features.Students.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Students.Commands.Create;
public class CreateStudentCommand : IRequest<CreatedStudentResponse>
{
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Class { get; set; }
    public int TeacherId { get; set; }
    public int ParentId { get; set; }
    public int SchoolId { get; set; }

    public CreateStudentCommand()
    {
        Name = string.Empty;
        DateOfBirth = default(DateTime);
        Class = string.Empty;
    }

    public CreateStudentCommand(string name, DateTime dateOfBirth, string studentClass, int teacherId, int parentId, int schoolId)
    {
        Name = name;
        DateOfBirth = dateOfBirth;
        Class = studentClass;
        TeacherId = teacherId;
        ParentId = parentId;
        SchoolId = schoolId;
    }

    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, CreatedStudentResponse>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;
        private readonly StudentBusinessRules _studentBusinessRules;

        public CreateStudentCommandHandler(IStudentRepository studentRepository, IMapper mapper, StudentBusinessRules studentBusinessRules)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
            _studentBusinessRules = studentBusinessRules;
        }

        public async Task<CreatedStudentResponse> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            Student student = _mapper.Map<Student>(request);

            Student createdStudent = await _studentRepository.AddAsync(student);
            CreatedStudentResponse response = _mapper.Map<CreatedStudentResponse>(createdStudent);
            return response;
        }
    }
}