namespace PatternsSandbox.Patterns.Behavioral.Mediator.Implementations;

public sealed class Component2 : BaseComponent
{
	public void DoC()
	{
		MessageBuilder?.AppendLine("Component 2 does C.");

		this.Mediator?.Notify(this, "C");
	}

	public void DoD()
	{
		MessageBuilder?.AppendLine("Component 2 does D.");

		this.Mediator?.Notify(this, "D");
	}
}
