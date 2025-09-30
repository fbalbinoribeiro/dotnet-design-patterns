using PatternsSandbox.Patterns.Behavioral.Mediator.Interfaces;
using System.Text;

namespace PatternsSandbox.Patterns.Behavioral.Mediator.Implementations;

public sealed class Mediator : IMediator
{
	private readonly Component1 _component1;
	private readonly Component2 _component2;
	private readonly StringBuilder _messageBuilder;

	public Mediator(Component1 component1, Component2 component2, StringBuilder messageBuilder)
	{
		_component1 = component1;
		_component1.SetMediator(this);
		_component1.SetMessageBuilder(messageBuilder);
		_component2 = component2;
		_component2.SetMediator(this);
		_component2.SetMessageBuilder(messageBuilder);
		_messageBuilder = messageBuilder;
	}

	public void Notify(object sender, string eventName)
	{
		if (eventName == "A")
		{
			_messageBuilder.AppendLine("Mediator reacts on A and triggers following operations:");
			_component2.DoC();
		}
		else if (eventName == "D")
		{
			_messageBuilder.AppendLine("Mediator reacts on D and triggers following operations:");
			_component1.DoB();
			_component2.DoC();
		}
	}
}