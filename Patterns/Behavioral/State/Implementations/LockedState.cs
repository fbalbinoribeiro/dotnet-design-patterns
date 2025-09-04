using PatternsSandbox.Patterns.Behavioral.State.Abstractions;

namespace PatternsSandbox.Patterns.Behavioral.State.Implementations;

public sealed record LockedState(AudioPlayer AudioPlayer) : AbstractState(AudioPlayer)
{
	public override void ClickLock() => AudioPlayer.ChangeState(new ReadyState(AudioPlayer));
	public override void ClickNext() { }
	public override void ClickPlay() { }
	public override void ClickPrevious() { }
}