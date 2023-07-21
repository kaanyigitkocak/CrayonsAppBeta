using Application.Features.Parents.Rules;
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

namespace Application.Features.Parents.Queries.GetById;
public class GetByIdParentQuery : IRequest<GetByIdParentResponse>
{
    public int Id { get; set; }

    public class GetByIdParentQueryHandler : IRequestHandler<GetByIdParentQuery, GetByIdParentResponse>
    {
        private readonly IParentRepository _parentRepository;
        private readonly IMapper _mapper;
        private readonly ParentBusinessRules _parentBusinessRules;

        public GetByIdParentQueryHandler(IParentRepository parentRepository, IMapper mapper, ParentBusinessRules parentBusinessRules)
        {
            _parentRepository = parentRepository;
            _mapper = mapper;
            _parentBusinessRules = parentBusinessRules;
        }

        public async Task<GetByIdParentResponse> Handle(GetByIdParentQuery request, CancellationToken cancellationToken)
        {
            Parent? parent = await _parentRepository.GetAsync(predicate: b => b.Id == request.Id,
                                                              include: p => p.Include(p => p.Students),
                                                              cancellationToken: cancellationToken);

            GetByIdParentResponse response = _mapper.Map<GetByIdParentResponse>(parent);
            return response;
        }
    }
}

