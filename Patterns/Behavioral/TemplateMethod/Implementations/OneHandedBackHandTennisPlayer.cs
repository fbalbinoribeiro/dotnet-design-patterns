using PatternsSandbox.Patterns.Behavioral.TemplateMethod.Abstractions;

namespace PatternsSandbox.Patterns.Behavioral.TemplateMethod.Implementations;

public sealed record OneHandedBackHandTennisPlayer(string Name) : AbstractTennisPlayer(Name)
{
	protected override void PrepareForMatch() => Steps.Add($"{Name} is getting ready for the match with a one-handed backhand.");
	protected override void PlaySet() => Steps.Add($"{Name} is playing a set with a one-handed backhand.");
}