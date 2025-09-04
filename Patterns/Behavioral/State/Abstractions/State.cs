using PatternsSandbox.Patterns.Behavioral.State.Implementations;

namespace PatternsSandbox.Patterns.Behavioral.State.Abstractions;

public abstract record AbstractState
{
	private readonly AudioPlayer _audioPlayer;

	protected AbstractState(AudioPlayer audioPlayer)
	{
		_audioPlayer = audioPlayer;
	}

	public abstract void ClickLock();
	public abstract void ClickPlay();
	public abstract void ClickNext();
	public abstract void ClickPrevious();
}