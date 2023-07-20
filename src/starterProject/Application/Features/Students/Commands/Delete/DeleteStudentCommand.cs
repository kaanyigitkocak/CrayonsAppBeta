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

namespace Application.Features.Students.Commands.Delete;
public class DeleteStudentCommand : IRequest<DeletedStudentResponse>
{
    public int Id { get; set; }

    public DeleteStudentCommand()
    {

    }

    public DeleteStudentCommand(int id)
    {
        Id = id;
    }

    public class DeleteStudentCommandHandler : IRequestHandler<DeleteStudentCommand, DeletedStudentResponse>
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;
        private readonly StudentBusinessRules _studentBusinessRules;

        public DeleteStudentCommandHandler(IStudentRepository studentRepository, IMapper mapper, StudentBusinessRules studentBusinessRules)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
            _studentBusinessRules = studentBusinessRules;
        }

        public async Task<DeletedStudentResponse> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            Student? student = await _studentRepository.GetAsync(predicate: s => s.Id == request.Id, cancellationToken: cancellationToken);


            await _studentRepository.DeleteAsync(student);

            DeletedStudentResponse response = _mapper.Map<DeletedStudentResponse>(student);
            return response;
        }
    }
}