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
        Task<TResponse> response;
        using (CancellationTokenSource cts = new CancellationTokenSource())
        {
            CancellationToken combinedCancellationToken = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, cts.Token).Token;
            response = Task.Run(() => next(), combinedCancellationToken);

            
            if (await Task.WhenAny(response, Task.Delay(request.TimeoutTime, combinedCancellationToken)) == response)
            {
                cts.Cancel();
                return await response;
            }
            else
            {
                throw new TimeoutException($"Request exceeded {request.TimeoutTime.TotalSeconds} seconds.");
            }
        }
    }
    
}