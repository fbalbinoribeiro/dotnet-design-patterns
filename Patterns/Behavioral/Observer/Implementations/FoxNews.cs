using PatternsSandbox.Patterns.Behavioral.Observer.Abstractions;

namespace PatternsSandbox.Patterns.Behavioral.Observer.Implementations;

public sealed record FoxNews : TvChannel
{
	public override string Name => "Fox News";
}
