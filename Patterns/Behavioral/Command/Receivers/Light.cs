namespace PatternsSandbox.Patterns.Behavioral.Command.Receivers;

public sealed record Light
{
	public bool IsOn { get; set; }

	public void TurnOn() => IsOn = true;
	public void TurnOff() => IsOn = false;
}