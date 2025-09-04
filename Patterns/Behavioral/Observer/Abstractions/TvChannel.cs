using PatternsSandbox.Patterns.Behavioral.Observer.Events;
using static PatternsSandbox.Patterns.Behavioral.Observer.Events.NewsAgency;

namespace PatternsSandbox.Patterns.Behavioral.Observer.Abstractions;

public abstract record TvChannel
{
	public abstract string Name { get; }
	protected NewsAgency? _eventHandler;
	public List<string> News { get; } = [];

	public void Subscribe(NewsAgency newsAgency)
	{
		_eventHandler = newsAgency;
		_eventHandler.NewsPublished += OnNewsPublished;
	}

	public void Unsubscribe()
	{
		if (_eventHandler is not null)
		{
			_eventHandler.NewsPublished -= OnNewsPublished;
			_eventHandler = null;
		}
	}

	public void OnNewsPublished(object? sender, NewsEventArgs e) =>
		News.Add($"[{Name}] Breaking News: {e.Message} at {e.PublishedAt}");
}
