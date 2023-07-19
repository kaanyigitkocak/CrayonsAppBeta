using Application.Features.Parents.Rules;
using Application.Services.Repositories;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Entities;
using System.Threading.Tasks;
using Core.Security.Entities;
using Application.Features.Parents.Commands.Update;

namespace Application.Features.Parents.Commands.Update;
public class CreateParentCommand  : IRequest<CreatedParentResponse>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public int PhoneNumber { get; set; }
    public int StudentId { get; set; }

    public CreateParentCommand()
    {
        Name = string.Empty;
        Email = string.Empty;
        PhoneNumber = default;
    }

    public CreateParentCommand(int id, int studentId, string name, int phoneNumber, string email)
    {
        Id = id;
        StudentId = studentId;
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public class CreateParentCommandHandler : IRequestHandler<CreateParentCommand, CreatedParentResponse>
    {
        private readonly IParentRepository _parentRepository;
        private readonly IMapper _mapper;
        private readonly ParentBusinessRules _parentBusinessRules;

        public CreateParentCommandHandler(IParentRepository parentRepository, IMapper mapper, ParentBusinessRules parentBusinessRules)
        {
            _parentRepository = parentRepository;
            _mapper = mapper;
            _parentBusinessRules = parentBusinessRules;
        }
        public async Task<CreatedParentResponse> Handle(CreateParentCommand request, CancellationToken cancellationToken)
        {

            Parent parent = _mapper.Map<Parent>(request);
            Parent createdParent = await _parentRepository.AddAsync(parent);
            CreatedParentResponse response = _mapper.Map<CreatedParentResponse>(createdParent);
            return response;

        }
    }
}