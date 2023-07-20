using Core.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Students.Queries.GetList;

public class GetListStudentListItemResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Class { get; set; }
    public string ParentName { get; set; }
    public string ParentEmail { get; set; }
    public string ParentPhoneNumber { get; set; }
    public string SchoolName { get; set; }
    public string SchoolAddress { get; set; }
    public string SchoolPhoneNumber { get; set; }
    public string TeacherName { get; set; }
    public string TeacherEmail { get; set; }
    public string TeacherPhoneNumber { get; set; }
    public DateTime TeacherHireDate { get; set; }

    public GetListStudentListItemResponse()
    {
        Name = string.Empty;
        DateOfBirth = DateTime.MinValue;
        Class = string.Empty;
        ParentName = string.Empty;
        ParentEmail = string.Empty;
        ParentPhoneNumber = string.Empty;
        SchoolName = string.Empty;
        SchoolAddress = string.Empty;
        SchoolPhoneNumber = string.Empty;
        TeacherName = string.Empty;
        TeacherEmail = string.Empty;
        TeacherPhoneNumber = string.Empty;
        TeacherHireDate = DateTime.MinValue;
    }

    public GetListStudentListItemResponse(int id, string name, DateTime dateOfBirth, string studentClass,
        string parentName, string parentEmail, string parentPhoneNumber,
        string schoolName, string schoolAddress, string schoolPhoneNumber,
        string teacherName, string teacherEmail, string teacherPhoneNumber, DateTime teacherHireDate)
    {
        Id = id;
        Name = name;
        DateOfBirth = dateOfBirth;
        Class = studentClass;
        ParentName = parentName;
        ParentEmail = parentEmail;
        ParentPhoneNumber = parentPhoneNumber;
        SchoolName = schoolName;
        SchoolAddress = schoolAddress;
        SchoolPhoneNumber = schoolPhoneNumber;
        TeacherName = teacherName;
        TeacherEmail = teacherEmail;
        TeacherPhoneNumber = teacherPhoneNumber;
        TeacherHireDate = teacherHireDate;
    }
}