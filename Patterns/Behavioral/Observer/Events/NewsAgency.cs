namespace PatternsSandbox.Patterns.Behavioral.Observer.Events;

public sealed record NewsAgency
{
	public sealed class NewsEventArgs(string message) : EventArgs
	{
		public string Message { get; } = message;
		public DateTime PublishedAt { get; } = DateTime.Now;
	}

	public event EventHandler<NewsEventArgs>? NewsPublished;

	public void PublishNews(string message)
	{
		var args = new NewsEventArgs(message);
		NewsPublished?.Invoke(this, args);
	}
}
