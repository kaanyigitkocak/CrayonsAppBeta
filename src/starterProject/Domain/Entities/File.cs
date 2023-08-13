using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public  class File : Entity<int>
{
    public string Name { get; set; }
    public string FullPath { get; set; }

    public string MimeType { get; set; }
    public virtual Student Student { get; set; }
    public virtual Invoice Invoice { get; set; }
}
