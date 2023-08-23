using Application.Features.Parents.Rules;
using Application.HangfireJobs.ContinuationsJobs;
using Application.HangfireJobs.DelayedJobs;
using Application.HangfireJobs.FireAndForgetJobs;
using Application.Notifications.Mails;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Pipelines.Logging;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Parents.Queries.GetById;
public class GetByIdParentQuery : IRequest<GetByIdParentResponse>, ILoggableRequest
{
    public int Id { get; set; }

    public class GetByIdParentQueryHandler : IRequestHandler<GetByIdParentQuery, GetByIdParentResponse>
    {
        private readonly IParentRepository _parentRepository;
        private readonly IMapper _mapper;
        private readonly ParentBusinessRules _parentBusinessRules;
        private readonly IMediator _mediator;
        public GetByIdParentQueryHandler(IParentRepository parentRepository, IMapper mapper, ParentBusinessRules parentBusinessRules, IMediator mediator)
        {
            _parentRepository = parentRepository;
            _mapper = mapper;
            _parentBusinessRules = parentBusinessRules;
            _mediator = mediator;
        }

        public async Task<GetByIdParentResponse> Handle(GetByIdParentQuery request, CancellationToken cancellationToken)
        {
            await _mediator.Publish(new MailNotification("selam", "naber") , cancellationToken);
            FireAndForgetJobs.MailSend(request.Id, "Faf job");
            string  jobId = DelayedJobs.MailSend(request.Id, "Delayed Job",5);
            ContinuationsJobs.MailSend(jobId, request.Id, "Continuation Job");

            Parent? parent = await _parentRepository.GetAsync(predicate: b => b.Id == request.Id,
                                                              include: p => p.Include(p => p.Students),
                                                              cancellationToken: cancellationToken);

            GetByIdParentResponse response = _mapper.Map<GetByIdParentResponse>(parent);
            return response;
        }
    }
}

