using PatternsSandbox.Patterns.Behavioral.Chain.Abstractions;
using PatternsSandbox.Patterns.Behavioral.Chain.Models;

namespace PatternsSandbox.Patterns.Behavioral.Chain.Implementations;

public sealed class DirectorApprovalHandler : HandlerBase<PurchaseOrder, ApprovalResult>
{
    protected override bool TryHandle(PurchaseOrder request, out ApprovalResult response)
    {
        if (request.Amount <= 10_000m)
        {
            response = ApprovalResult.Granted("Director");
            return true;
        }

        response = ApprovalResult.Denied("Amount");
        return false;
    }
}