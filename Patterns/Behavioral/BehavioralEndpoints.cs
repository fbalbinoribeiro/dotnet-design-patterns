using PatternsSandbox.Patterns.Behavioral.Command;
using PatternsSandbox.Patterns.Behavioral.Strategy;
using PatternsSandbox.Patterns.Behavioral.TemplateMethod;

namespace PatternsSandbox.Patterns.Behavioral;

public static class BehavioralEndpoints
{
	public static void MapBehavioralEndpoints(this IEndpointRouteBuilder routes)
	{
		var app = routes.MapGroup("/behavioral");
		StrategyEndpoints.MapEndpoints(app);
		TemplateMethodEndpoints.MapEndpoints(app);
		CommandEndpoints.MapEndpoints(app);
	}
}
