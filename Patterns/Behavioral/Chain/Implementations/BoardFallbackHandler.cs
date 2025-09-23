using PatternsSandbox.Patterns.Behavioral.Chain.Abstractions;
using PatternsSandbox.Patterns.Behavioral.Chain.Models;

namespace PatternsSandbox.Patterns.Behavioral.Chain.Implementations;

public sealed class BoardFallbackHandler : HandlerBase<PurchaseOrder, ApprovalResult>
{
    protected override bool TryHandle(PurchaseOrder request, out ApprovalResult response)
    {
        response = ApprovalResult.Denied("Fallback");
        return false;
    }

    protected override Task<ApprovalResult> HandleNotHandledAsync(PurchaseOrder request, CancellationToken ct) =>
        Task.FromResult(ApprovalResult.Denied("Requires Board approval"));
}