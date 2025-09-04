using PatternsSandbox.Patterns.Behavioral.Strategy.Implementations;
using PatternsSandbox.Patterns.Behavioral.Strategy.Interfaces;

namespace PatternsSandbox.Patterns.Behavioral.Strategy;

public static class StrategyEndpoints
{
	public static void MapEndpoints(this IEndpointRouteBuilder routes)
	{
		routes.MapPost("/strategy", (string operation, byte firstNumber, byte secondNumber) =>
		{
			IStrategy strategy = operation switch
			{
				"add" => new AddStrategy(),
				"subtract" => new SubtractStrategy(),
				"multiply" => new MultiplyStrategy(),
				_ => throw new ArgumentException("Invalid operation")
			};

			var result = strategy.Execute(firstNumber, secondNumber);
			return Results.Ok(result);
		})
		.WithName("Strategy")
		.WithOpenApi(op =>
		{
			var param = op.Parameters.FirstOrDefault(p => p.Name == "operation");
			if (param is not null)
			{
				param.Description = "add, subtract, multiply.";
			}
			return op;
		});
	}
}
