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

namespace Application.Features.Students.Commands.Update;
public class UpdateStudentCommand : IRequest<UpdatedStudentResponse>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Class { get; set; }
    public int TeacherId { get; set; }
    public int ParentId { get; set; }
    public int SchoolId { get; set; }

    public UpdateStudentCommand()
    {
        Name = string.Empty;
        DateOfBirth = default(DateTime);
        Class = string.Empty;
    }

    public UpdateStudentCommand(int id, string name, DateTime dateOfBirth, string studentClass, int teacherId, int parentId, int schoolId)
    {
        Id = id;
        Name = name;
        DateOfBirth = dateOfBirth;
        Class = studentClass;
        TeacherId = teacherId;
        ParentId = parentId;
        SchoolId = schoolId;
    }

    public class UpdateStudentCommandHandler : IRequestHandler<UpdateStudentCommand, UpdatedStudentResponse>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;
        private readonly StudentBusinessRules _studentBusinessRules;

        public UpdateStudentCommandHandler(IStudentRepository studentRepository, IMapper mapper, StudentBusinessRules studentBusinessRules)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
            _studentBusinessRules = studentBusinessRules;
        }

        public async Task<UpdatedStudentResponse> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            Student student = _mapper.Map<Student>(request);


            Student updatedStudent = await _studentRepository.UpdateAsync(student);
            UpdatedStudentResponse response = _mapper.Map<UpdatedStudentResponse>(updatedStudent);
            return response;
        }
    }
}