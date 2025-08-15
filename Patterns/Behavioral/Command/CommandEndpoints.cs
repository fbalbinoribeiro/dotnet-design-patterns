using PatternsSandbox.Patterns.Behavioral.Command.Implementations;
using PatternsSandbox.Patterns.Behavioral.Command.Interfaces;
using PatternsSandbox.Patterns.Behavioral.Command.Receivers;

namespace PatternsSandbox.Patterns.Behavioral.Command;

public static class CommandEndpoints
{
	public static void MapEndpoints(this IEndpointRouteBuilder routes)
	{
		routes.MapPost("/command", (string action) =>
		{
			var light = new Light();

			ICommand command = action switch
			{
				"on" => new LightOnCommand(light),
				"off" => new LightOffCommand(light),
				_ => throw new ArgumentException("Invalid action")
			};

			command.Execute();
			return Results.Ok($"Light is now {(light.IsOn ? "on" : "off")}.");
		})
		.WithName("BehavioralCommand")
		.WithOpenApi(op =>
		{
			var param = op.Parameters.FirstOrDefault(p => p.Name == "action");
			if (param is not null)
			{
				param.Description = "on, off.";
			}
			return op;
		});
	}
}