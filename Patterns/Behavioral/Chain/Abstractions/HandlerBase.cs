using PatternsSandbox.Patterns.Behavioral.Chain.Interfaces;

namespace PatternsSandbox.Patterns.Behavioral.Chain.Abstractions;

public abstract class HandlerBase<TRequest, TResponse> : IHandler<TRequest, TResponse>
{
    private IHandler<TRequest, TResponse>? _next;

    public IHandler<TRequest, TResponse> SetNext(IHandler<TRequest, TResponse> next)
    {
        _next = next;
        return next;
    }

    public async Task<TResponse> HandleAsync(TRequest request, CancellationToken ct = default)
    {
        if (TryHandle(request, out TResponse response))
        {
            return response;
        }

        if (_next is not null)
        {
            return await _next.HandleAsync(request, ct);
        }

        return await HandleNotHandledAsync(request, ct);
    }

    protected abstract bool TryHandle(TRequest request, out TResponse response);

    protected virtual Task<TResponse> HandleNotHandledAsync(TRequest request, CancellationToken ct) =>
        throw new InvalidOperationException("Request was not handled and no fallback provided.");
}
