using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.Pipelines.Timeout;
public class TimeoutBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    where TRequest : IRequest<TResponse>, ITimeoutRequest
{
   
    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        
    {
        using var cts = new CancellationTokenSource();
        var combinedCancellationToken = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, cts.Token);

        var task = Task.Run(() => next(), combinedCancellationToken.Token);

        if (await Task.WhenAny(task, Task.Delay(request.TimeoutTime , combinedCancellationToken.Token)) == task)
        {
            cts.Cancel();
            return await task;
        }
        else
        {
            throw new TimeoutException($"Request exceeded {request.TimeoutTime.TotalSeconds} seconds.");
        }
    }
}