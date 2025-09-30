using PatternsSandbox.Patterns.Behavioral.Mediator.Implementations;
using System.Text;

namespace PatternsSandbox.Patterns.Behavioral.Mediator;

public static class MediatorEndpoints
{
	public static void MapEndpoints(this IEndpointRouteBuilder routes)
	{
		routes.MapGet("/mediator", () =>
		{
			var messageBuilder = new StringBuilder();
			var component1 = new Component1();
			var component2 = new Component2();

			var mediator = new Implementations.Mediator(component1, component2, messageBuilder);

			component1.DoA();
			component2.DoD();

			var messages = messageBuilder.ToString()
				.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries)
				.ToList();

			return Results.Ok(messages);
		})
		.WithName("Mediator")
		.WithOpenApi();
	}
}