namespace PatternsSandbox.Patterns.Behavioral.TemplateMethod.Abstractions;

public abstract record TennisPlayer(string Name)
{
	public string Name { get; } = Name;
	public List<string> Steps { get; } = [];

	public void PlayMatch()
	{
		PrepareForMatch();
		PlaySet();
		PlaySet();
		PlaySet();
		EndMatch();
	}

	protected abstract void PlaySet();

	protected virtual void PrepareForMatch() => Steps.Add($"{Name} is getting ready for the match.");
	protected virtual void EndMatch() => Steps.Add($"{Name} has finished the match.");
}
