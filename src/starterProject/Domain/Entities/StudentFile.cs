using Core.Persistence.Repositories;
using Core.Security.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class StudentFile : File
{
    public int StudentId { get; set; }

    public virtual Student Student { get; set; } 
}