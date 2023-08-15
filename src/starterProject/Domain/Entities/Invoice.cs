using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Invoice : Entity<int>
{
    public string InvoiceNumber { get; set; }
    public string Detail { get; set; }
    public decimal Amount { get; set; }
    public bool IsPaid { get; set; }
    public DateTime DueDate { get; set; }
    public int ParentId { get; set; }
    public virtual Parent? Parent { get; set; }
    public virtual ICollection<InvoiceFile> InvoiceFiles { get; set; }
}
