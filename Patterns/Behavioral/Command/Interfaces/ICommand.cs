namespace PatternsSandbox.Patterns.Behavioral.Command.Interfaces;

public interface ICommand
{
    void Execute();
    void Undo();
}
	