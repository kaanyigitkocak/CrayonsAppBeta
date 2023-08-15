using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class InvoiceFile : File
{
    public int InvoiceId { get; set; }
    public virtual Invoice Invoice { get; set; }
}