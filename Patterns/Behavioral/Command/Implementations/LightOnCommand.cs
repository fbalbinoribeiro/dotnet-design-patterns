using PatternsSandbox.Patterns.Behavioral.Command.Interfaces;
using PatternsSandbox.Patterns.Behavioral.Command.Receivers;

namespace PatternsSandbox.Patterns.Behavioral.Command.Implementations;

public sealed record LightOnCommand(Light Light) : ICommand
{
	public void Execute() => Light.TurnOn();
	public void Undo() => Light.TurnOff();
}