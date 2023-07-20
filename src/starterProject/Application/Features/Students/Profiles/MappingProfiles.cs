using Application.Features.Parents.Commands.Delete;
using Application.Features.Parents.Commands.Update;
using Application.Features.Parents.Queries.GetById;
using Application.Features.Students.Commands.Create;
using Application.Features.Students.Commands.Delete;
using Application.Features.Students.Commands.Update;
using Application.Features.Students.Queries.GetById;
using Application.Features.Students.Queries.GetList;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Students.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Student, CreateStudentCommand>().ReverseMap();
        CreateMap<Student, CreatedStudentResponse>().ReverseMap();
        CreateMap<Student, UpdateStudentCommand>().ReverseMap();
        CreateMap<Student, UpdatedStudentResponse>().ReverseMap();
        CreateMap<Student, DeleteStudentCommand>().ReverseMap();
        CreateMap<Student, DeletedStudentResponse>().ReverseMap();
        CreateMap<Student, GetByIdStudentResponse>().ReverseMap();
        CreateMap<Student, GetListStudentListItemResponse>()
            .ForMember(dest => dest.ParentName, opt => opt.MapFrom(src => src.Parent != null ? src.Parent.Name : null))
            .ForMember(dest => dest.ParentEmail, opt => opt.MapFrom(src => src.Parent != null ? src.Parent.Email : null))
            .ForMember(dest => dest.ParentPhoneNumber, opt => opt.MapFrom(src => src.Parent != null ? src.Parent.PhoneNumber : null))
            .ForMember(dest => dest.SchoolName, opt => opt.MapFrom(src => src.School != null ? src.School.Name : null))
            .ForMember(dest => dest.SchoolAddress, opt => opt.MapFrom(src => src.School != null ? src.School.Address : null))
            .ForMember(dest => dest.SchoolPhoneNumber, opt => opt.MapFrom(src => src.School != null ? src.School.PhoneNumber : null))
            .ForMember(dest => dest.TeacherName, opt => opt.MapFrom(src => src.Teacher != null ? src.Teacher.Name : null))
            .ForMember(dest => dest.TeacherEmail, opt => opt.MapFrom(src => src.Teacher != null ? src.Teacher.Email : null))
            .ForMember(dest => dest.TeacherPhoneNumber, opt => opt.MapFrom(src => src.Teacher != null ? src.Teacher.PhoneNumber : null))
            .ForMember(dest => dest.TeacherHireDate, opt => opt.MapFrom(src => src.Teacher != null ? src.Teacher.HireDate : (DateTime?)null));
        CreateMap<IPaginate<Student>, GetListResponse<GetListStudentListItemResponse>>().ReverseMap();
    }
}