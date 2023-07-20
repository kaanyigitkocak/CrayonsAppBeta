using Core.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Students.Commands.Delete;
public class DeletedStudentResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Class { get; set; }
    public int TeacherId { get; set; }
    public int ParentId { get; set; }
    public int SchoolId { get; set; }

    public DeletedStudentResponse()
    {
        Name = string.Empty;
        DateOfBirth = default(DateTime);
        Class = string.Empty;
        TeacherId = 0;
        ParentId = 0;
        SchoolId = 0;
    }

    public DeletedStudentResponse(int id, string name, DateTime dateOfBirth, string studentClass, int teacherId, int parentId, int schoolId)
    {
        Id = id;
        Name = name;
        DateOfBirth = dateOfBirth;
        Class = studentClass;
        TeacherId = teacherId;
        ParentId = parentId;
        SchoolId = schoolId;
    }
}