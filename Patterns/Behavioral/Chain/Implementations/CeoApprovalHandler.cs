using PatternsSandbox.Patterns.Behavioral.Chain.Abstractions;
using PatternsSandbox.Patterns.Behavioral.Chain.Models;

namespace PatternsSandbox.Patterns.Behavioral.Chain.Implementations;

public sealed class CeoApprovalHandler : HandlerBase<PurchaseOrder, ApprovalResult>
{
    protected override bool TryHandle(PurchaseOrder request, out ApprovalResult response)
    {
        if (request.Amount <= 100_000m)
        {
            response = ApprovalResult.Granted("CEO");
            return true;
        }

        response = ApprovalResult.Denied("Amount");
        return false;
    }
}