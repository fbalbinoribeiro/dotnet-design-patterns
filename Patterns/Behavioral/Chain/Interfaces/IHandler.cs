namespace PatternsSandbox.Patterns.Behavioral.Chain.Interfaces;

public interface IHandler<TRequest, TResponse>
{
    IHandler<TRequest, TResponse> SetNext(IHandler<TRequest, TResponse> next);
    Task<TResponse> HandleAsync(TRequest request, CancellationToken ct = default);
}