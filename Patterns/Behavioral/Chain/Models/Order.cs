namespace PatternsSandbox.Patterns.Behavioral.Chain.Models;

public readonly record struct PurchaseOrder(decimal Amount, string RequestedBy);

public readonly record struct ApprovalResult(bool Approved, string? ApprovedBy = null, string? Reason = null)
{
    public static ApprovalResult Denied(string reason) => new(false, null, reason);
    public static ApprovalResult Granted(string approver) => new(true, approver, null);
}