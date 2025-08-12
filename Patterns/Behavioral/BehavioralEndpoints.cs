using PatternsSandbox.Patterns.Behavioral.Strategy;

namespace PatternsSandbox.Patterns.Behavioral;

public static class BehavioralEndpoints
{
	public static void MapBehavioralEndpoints(this IEndpointRouteBuilder routes)
	{
		var app = routes.MapGroup("/behavioral");
		StrategyEndpoints.MapStrategyEndpoints(app);
	}
}
