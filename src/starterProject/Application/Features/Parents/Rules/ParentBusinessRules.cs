using Application.Services.Repositories;
using Core.Application.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Parents.Rules;
public class ParentBusinessRules : BaseBusinessRules
{
    private readonly IParentRepository _parentRepository;

    public ParentBusinessRules(IParentRepository parentRepository)
    {
        _parentRepository = parentRepository;
    }

    
}
