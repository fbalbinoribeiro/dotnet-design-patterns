namespace PatternsSandbox.Patterns.Behavioral.Mediator.Implementations;

public sealed class Component1 : BaseComponent
{
	public void DoA()
	{
		MessageBuilder?.AppendLine("Component 1 does A.");

		this.Mediator?.Notify(this, "A");
	}

	public void DoB()
	{
		MessageBuilder?.AppendLine("Component 1 does B.");

		this.Mediator?.Notify(this, "B");
	}
}
