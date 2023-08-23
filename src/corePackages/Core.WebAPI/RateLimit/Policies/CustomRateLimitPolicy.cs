using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.RateLimiting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core.Tokenizer;
using System.Text;
using System.Threading.RateLimiting;
using System.Threading.Tasks;

namespace Core.WebAPI.RateLimit.Policies;
public class CustomRateLimitPolicy : IRateLimiterPolicy<string>
{
    public Func<OnRejectedContext, CancellationToken, ValueTask> OnRejected => async (context, cancellationToken) =>
    {
        context.HttpContext.Response.StatusCode = 429;
        await context.HttpContext.Response.WriteAsync(
            $"You have made too many requests. Please try again in a few munites.", cancellationToken);
    };



    public RateLimitPartition<string> GetPartition(HttpContext httpContext)
    {
        return RateLimitPartition.GetSlidingWindowLimiter("", _ => new()
        {
            PermitLimit = 4,
            Window = TimeSpan.FromSeconds(12),
            QueueProcessingOrder = QueueProcessingOrder.OldestFirst,
            SegmentsPerWindow = 2,
            QueueLimit = 0
        });
    }
}