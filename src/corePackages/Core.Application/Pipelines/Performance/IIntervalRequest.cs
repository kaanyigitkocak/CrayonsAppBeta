namespace Core.Application.Pipelines.Performance;

public interface IIntervalRequest
{
    public TimeSpan Interval { get; }
}
