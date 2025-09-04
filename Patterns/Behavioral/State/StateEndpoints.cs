using PatternsSandbox.Patterns.Behavioral.State.Implementations;

namespace PatternsSandbox.Patterns.Behavioral.State;

public static class StateEndpoints
{
	public static void MapEndpoints(this IEndpointRouteBuilder routes)
	{
		routes.MapGet("/state", () =>
		{
			var states = new List<string>();
			var player = new AudioPlayer();
			states.Add(player.State);
			player.ClickPlay();
			states.Add(player.State);
			player.ClickNext();
			player.ClickPrevious();
			player.ClickLock();
			states.Add(player.State);
			player.ClickLock();
			states.Add(player.State);

			return Results.Ok(states);
		})
		.WithName("State")
		.WithOpenApi();
	}
}
