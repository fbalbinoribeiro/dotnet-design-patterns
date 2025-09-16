using System.Text;

namespace PatternsSandbox.Patterns.Behavioral.Memento.Implementations;

public sealed record TextEditor
{
	public StringBuilder Text { get; private set; } = new StringBuilder();

	public void Write(string newText)
	{
		Text.Append(newText);
	}

	public TextMemento Save() => new(Text.ToString());

	public void Restore(TextMemento memento)
	{
		Text.Clear();
		Text.Append(memento.Text);
	}
}