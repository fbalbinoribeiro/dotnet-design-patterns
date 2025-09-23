using PatternsSandbox.Patterns.Behavioral.Chain.Implementations;
using PatternsSandbox.Patterns.Behavioral.Chain.Models;

namespace PatternsSandbox.Patterns.Behavioral.Chain;

public static class ChainEndpoints
{
    public static void MapEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapGet("/chain", async () =>
        {
            var manager = new ManagerApprovalHandler();
            var director = new DirectorApprovalHandler();
            var ceo = new CeoApprovalHandler();
            var board = new BoardFallbackHandler();

            manager.SetNext(director).SetNext(ceo).SetNext(board);

            var orders = new List<PurchaseOrder>();

            orders.AddRange([
                new PurchaseOrder(250m, "Fabio"),
                new PurchaseOrder(8_000m, "Fabio"),
                new PurchaseOrder(50_000m, "Fabio"),
                new PurchaseOrder(500_000m, "Fabio")
            ]);

            var results = new List<string>();

            foreach (var order in orders)
            {
                var result = await manager.HandleAsync(order);
                results.Add($"Order for {order.Amount:C} by {order.RequestedBy}. " +
                            (result.Approved
                                ? $"Approved by {result.ApprovedBy}."
                                : $"Denied. Reason: {result.Reason}."));
            }

            return Results.Ok(results);
        })
            .WithName("Chain")
            .WithOpenApi();
    }
}
