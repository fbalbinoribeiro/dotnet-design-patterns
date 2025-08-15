using PatternsSandbox.Patterns.Behavioral.Command.Interfaces;
using PatternsSandbox.Patterns.Behavioral.TemplateMethod.Abstractions;

namespace PatternsSandbox.Patterns.Behavioral.TemplateMethod.Implementations;

public sealed record TwoHandedBackHandTennisPlayer(string Name) : TennisPlayer(Name)
{
	protected override void PlaySet() => Steps.Add($"{Name} is playing a set with a two-handed backhand.");
	protected override void EndMatch() => Steps.Add($"{Name} has finished the match with a two-handed backhand.");
}