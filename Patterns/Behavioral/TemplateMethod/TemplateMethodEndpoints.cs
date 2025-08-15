using PatternsSandbox.Patterns.Behavioral.Command.Interfaces;
using PatternsSandbox.Patterns.Behavioral.TemplateMethod.Abstractions;
using PatternsSandbox.Patterns.Behavioral.TemplateMethod.Implementations;

namespace PatternsSandbox.Patterns.Behavioral.TemplateMethod;

public static class TemplateMethodEndpoints
{

	public static void MapEndpoints(this IEndpointRouteBuilder routes)
	{
		routes.MapPost("/template-method", (string playerType) =>
		{
			TennisPlayer player = playerType switch
			{
				"one-handed" => new OneHandedBackHandTennisPlayer("Player1"),
				"two-handed" => new TwoHandedBackHandTennisPlayer("Player2"),
				_ => throw new ArgumentException("Invalid player type")
			};

			player.PlayMatch();

			return Results.Ok(player.Steps);
		})
		.WithName("BehavioralTemplateMethod")
		.WithOpenApi(op =>
		{
			var param = op.Parameters.FirstOrDefault(p => p.Name == "playerType");
			if (param is not null)
			{
				param.Description = "one-handed, two-handed.";
			}
			return op;
		});
	}
}