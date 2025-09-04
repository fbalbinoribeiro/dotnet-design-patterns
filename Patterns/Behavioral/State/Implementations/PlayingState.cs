using PatternsSandbox.Patterns.Behavioral.State.Abstractions;

namespace PatternsSandbox.Patterns.Behavioral.State.Implementations;

public sealed record PlayingState(AudioPlayer AudioPlayer) : AbstractState(AudioPlayer)
{
	public override void ClickLock() => AudioPlayer.ChangeState(new LockedState(AudioPlayer));
	public override void ClickNext() => AudioPlayer.NextSong();
	public override void ClickPlay() => AudioPlayer.ChangeState(new ReadyState(AudioPlayer));
	public override void ClickPrevious() => AudioPlayer.PreviousSong();
}