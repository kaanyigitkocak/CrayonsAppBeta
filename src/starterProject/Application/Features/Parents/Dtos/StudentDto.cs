using Core.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Parents.Dtos;
public class StudentDto : IDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Class { get; set; }
    public int TeacherId { get; set; }
    public int SchoolId { get; set; }
}
