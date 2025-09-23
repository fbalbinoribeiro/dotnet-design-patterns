using PatternsSandbox.Patterns.Behavioral.Chain.Abstractions;
using PatternsSandbox.Patterns.Behavioral.Chain.Models;

namespace PatternsSandbox.Patterns.Behavioral.Chain.Implementations;

public sealed class ManagerApprovalHandler : HandlerBase<PurchaseOrder, ApprovalResult>
{
    protected override bool TryHandle(PurchaseOrder request, out ApprovalResult response)
    {
        if (request.Amount <= 1_000m)
        {
            response = ApprovalResult.Granted("Manager");
            return true;
        }

        response = ApprovalResult.Denied("Amount");
        return false;
    }
}