using PatternsSandbox.Patterns.Behavioral.Chain;
using PatternsSandbox.Patterns.Behavioral.Command;
using PatternsSandbox.Patterns.Behavioral.Iterator;
using PatternsSandbox.Patterns.Behavioral.Mediator;
using PatternsSandbox.Patterns.Behavioral.Memento;
using PatternsSandbox.Patterns.Behavioral.Observer;
using PatternsSandbox.Patterns.Behavioral.State;
using PatternsSandbox.Patterns.Behavioral.Strategy;
using PatternsSandbox.Patterns.Behavioral.TemplateMethod;
using PatternsSandbox.Patterns.Behavioral.Visitor;

namespace PatternsSandbox.Patterns.Behavioral;

public static class BehavioralEndpoints
{
	public static void MapBehavioralEndpoints(this IEndpointRouteBuilder routes)
	{
		var app = routes.MapGroup("/behavioral").WithTags("Behavioral Patterns");
		StrategyEndpoints.MapEndpoints(app);
		TemplateMethodEndpoints.MapEndpoints(app);
		CommandEndpoints.MapEndpoints(app);
		IteratorEndpoints.MapEndpoints(app);
		StateEndpoints.MapEndpoints(app);
		ObserverEndpoints.MapEndpoints(app);
		MementoEndpoints.MapEndpoints(app);
		ChainEndpoints.MapEndpoints(app);
		MediatorEndpoints.MapEndpoints(app);
		VisitorEndpoints.MapEndpoints(app);
    }
}
