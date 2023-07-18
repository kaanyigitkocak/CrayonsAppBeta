using Application.Features.Parents.Rules;
using Application.Services.Repositories;
using AutoMapper;
using MediatR;
using Domain.Entities;


namespace Application.Features.Parents.Commands.Update;
public class UpdateParentCommand : IRequest<UpdatedParentResponse>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public int PhoneNumber { get; set; }

    public UpdateParentCommand()
    {
        Name = string.Empty;
        Email = string.Empty;
        PhoneNumber = default;
    }

    public UpdateParentCommand(int id, string name, int phoneNumber, string email)
    {
        Id = id;
        Name = name;
        PhoneNumber = phoneNumber;
        Email = email;

    }

    public class UpdateParentCommandHandler : IRequestHandler<UpdateParentCommand, UpdatedParentResponse>
    {
        private readonly IParentRepository _parentRepository;
        private readonly IMapper _mapper;
        private readonly ParentBusinessRules _parentBusinessRules;

        public UpdateParentCommandHandler(IParentRepository parentRepository, IMapper mapper, ParentBusinessRules parentBusinessRules)
        {
            _parentRepository = parentRepository;
            _mapper = mapper;
            _parentBusinessRules = parentBusinessRules;
        }
        public async Task<UpdatedParentResponse> Handle(UpdateParentCommand request, CancellationToken cancellationToken)
        {

            Parent parent = _mapper.Map<Parent>(request);
            Parent updatedParent = await _parentRepository.UpdateAsync(parent);
            UpdatedParentResponse response = _mapper.Map<UpdatedParentResponse>(updatedParent);
            return response;

        }
    }
}