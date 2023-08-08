using Application.Features.Schools.Constants;
using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Domain.Entities;

namespace Application.Features.Schools.Rules;

public class SchoolBusinessRules : BaseBusinessRules
{
    private readonly ISchoolRepository _schoolRepository;

    public SchoolBusinessRules(ISchoolRepository schoolRepository)
    {
        _schoolRepository = schoolRepository;
    }

    public Task SchoolShouldExistWhenSelected(School? school)
    {
        if (school == null)
            throw new BusinessException(SchoolsBusinessMessages.SchoolNotExists);
        return Task.CompletedTask;
    }

    public async Task SchoolIdShouldExistWhenSelected(int id, CancellationToken cancellationToken)
    {
        School? school = await _schoolRepository.GetAsync(
            predicate: s => s.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await SchoolShouldExistWhenSelected(school);
    }
}