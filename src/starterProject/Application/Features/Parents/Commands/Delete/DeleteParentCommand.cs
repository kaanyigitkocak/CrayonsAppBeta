using Application.Features.Parents.Commands.Update;
using Application.Features.Parents.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Parents.Commands.Delete;
public class DeleteParentCommand : IRequest<DeletedParentResponse>
{
    public int Id { get; set; }
    

    public DeleteParentCommand()
    {
      
    }

    public DeleteParentCommand(int id, string name, int phoneNumber, string email, bool status)
    {
        Id = id;
       

    }

    public class DeleteParentCommandHandler : IRequestHandler<DeleteParentCommand, DeletedParentResponse>
    {
        private readonly IParentRepository _parentRepository;
        private readonly IMapper _mapper;
        private readonly ParentBusinessRules _parentBusinessRules;

        public DeleteParentCommandHandler(IParentRepository parentRepository, IMapper mapper, ParentBusinessRules parentBusinessRules)
        {
            _parentRepository = parentRepository;
            _mapper = mapper;
            _parentBusinessRules = parentBusinessRules;
        }
        public async Task<DeletedParentResponse> Handle(DeleteParentCommand request, CancellationToken cancellationToken)
        {
            Parent? parent = await _parentRepository.GetAsync(predicate: p => p.Id == request.Id, cancellationToken: cancellationToken);
            await _parentRepository.DeleteAsync(parent!);
            DeletedParentResponse response = _mapper.Map<DeletedParentResponse>(parent);
            return response;
        }
    }
}