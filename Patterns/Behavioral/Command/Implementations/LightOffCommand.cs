using PatternsSandbox.Patterns.Behavioral.Command.Interfaces;
using PatternsSandbox.Patterns.Behavioral.Command.Receivers;

namespace PatternsSandbox.Patterns.Behavioral.Command.Implementations;

public sealed record LightOffCommand(Light Light) : ICommand
{
	public void Execute() => Light.TurnOff();
	public void Undo() => Light.TurnOn();
}