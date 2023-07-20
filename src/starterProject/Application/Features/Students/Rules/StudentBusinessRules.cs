using Application.Services.Repositories;
using Core.Application.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Students.Rules;
public class StudentBusinessRules : BaseBusinessRules
{
    private readonly IStudentRepository _studentRepository;

    public StudentBusinessRules(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }
}