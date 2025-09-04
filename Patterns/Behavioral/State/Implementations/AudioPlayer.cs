using PatternsSandbox.Patterns.Behavioral.State.Abstractions;

namespace PatternsSandbox.Patterns.Behavioral.State.Implementations;

public sealed record AudioPlayer
{
	private AbstractState _state;

	public AudioPlayer()
	{
		_state = new ReadyState(this);
	}

	public void ChangeState(AbstractState state) => _state = state;

	public void ClickLock() => _state.ClickLock();
	public void ClickPlay() => _state.ClickPlay();
	public void ClickNext() => _state.ClickNext();
	public void ClickPrevious() => _state.ClickPrevious();

	public void StartPlayback() { }
	public void StopPlayback() { }
	public void NextSong() { }
	public void PreviousSong() { }
	public void FastForward(int time) { }
	public void Rewind(int time) { }

	// It's only used to check the state from the endpoint
	public string State => _state.GetType().Name;

}