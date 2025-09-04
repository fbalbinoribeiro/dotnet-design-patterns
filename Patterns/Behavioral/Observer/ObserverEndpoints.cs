
using PatternsSandbox.Patterns.Behavioral.Observer.Events;
using PatternsSandbox.Patterns.Behavioral.Observer.Implementations;

namespace PatternsSandbox.Patterns.Behavioral.Observer;

public static class ObserverEndpoints
{
	public static void MapEndpoints(this IEndpointRouteBuilder routes)
	{
		routes.MapGet("/observer", () =>
		{
			var cnn = new Cnn();
			var foxNews = new FoxNews();
			var newsAgency = new NewsAgency();

			cnn.Subscribe(newsAgency);
			foxNews.Subscribe(newsAgency);

			newsAgency.PublishNews("Angular rocks!");
			newsAgency.PublishNews(".Net 99 released!");

			cnn.Unsubscribe();
			foxNews.Unsubscribe();

			return Results.Ok(new { Cnn = cnn.News, FoxNews = foxNews.News });
		})
		.WithName("Observer")
		.WithOpenApi();
	}
}
