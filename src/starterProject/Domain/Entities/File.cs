using Core.Persistence.Repositories;
using Core.Security.Entities;
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
    public string Discriminator { get; set; }
}
