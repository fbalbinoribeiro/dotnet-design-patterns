using PatternsSandbox.Patterns.Behavioral.Observer.Abstractions;

namespace PatternsSandbox.Patterns.Behavioral.Observer.Implementations;

public sealed record Cnn : TvChannel
{
	public override string Name => "CNN";
}
