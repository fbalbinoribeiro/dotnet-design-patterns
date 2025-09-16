namespace PatternsSandbox.Patterns.Behavioral.Memento.Implementations;

public sealed record History
{
	private readonly Stack<TextMemento> _undo = new();
	private readonly Stack<TextMemento> _redo = new();

	public void Backup(TextEditor editor)
	{
		_undo.Push(editor.Save());
		_redo.Clear();
	}

	public void Undo(TextEditor editor)
	{
		if (_undo.Count > 0)
		{
			_redo.Push(editor.Save());
			editor.Restore(_undo.Pop());
		}
	}

	public void Redo(TextEditor editor)
	{
		if (_redo.Count > 0)
		{
			_undo.Push(editor.Save());
			editor.Restore(_redo.Pop());
		}
	}
}