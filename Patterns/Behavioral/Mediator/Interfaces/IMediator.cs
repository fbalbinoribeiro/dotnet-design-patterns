namespace PatternsSandbox.Patterns.Behavioral.Mediator.Interfaces;

public interface IMediator
{
	void Notify(object sender, string eventName);
}
