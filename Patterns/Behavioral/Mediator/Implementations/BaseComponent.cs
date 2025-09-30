using PatternsSandbox.Patterns.Behavioral.Mediator.Interfaces;
using System.Text;

namespace PatternsSandbox.Patterns.Behavioral.Mediator.Implementations;

public partial class BaseComponent
{
	protected IMediator? Mediator { get; private set; }
	protected StringBuilder? MessageBuilder { get; private set; }

	public BaseComponent() { }

	public BaseComponent(IMediator mediator) => Mediator = mediator;

	public void SetMediator(IMediator mediator) => Mediator = mediator;

	public void SetMessageBuilder(StringBuilder messageBuilder) => MessageBuilder = messageBuilder;
}