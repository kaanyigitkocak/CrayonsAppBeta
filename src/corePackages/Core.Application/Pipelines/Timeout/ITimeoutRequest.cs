using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.Pipelines.Timeout;
public interface ITimeoutRequest
{
    public TimeSpan TimeoutTime { get; }
}
