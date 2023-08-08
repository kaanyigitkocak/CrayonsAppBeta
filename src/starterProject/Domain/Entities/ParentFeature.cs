using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class ParentFeature : Entity<int>
{
    public int Id { get; set; }
    public string FeatureName { get; set; }
    public int ParentId { get; set; }

    public Parent Parent { get; set; }
}