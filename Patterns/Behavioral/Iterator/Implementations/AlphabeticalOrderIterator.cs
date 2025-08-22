
using System.Collections;

namespace PatternsSandbox.Patterns.Behavioral.Iterator.Implementations;

public sealed record AlphabeticalOrderIterator : IEnumerator<string>
{
	private readonly WordsCollection _collection;
	private int _position = -1;

	public AlphabeticalOrderIterator(WordsCollection collection)
	{
		_collection = collection;
		_collection.GetItems().Sort();
	}

	public string Current => _collection.GetItems()[_position];

	object IEnumerator.Current => Current;

	public bool MoveNext()
	{
		_position++;
		return _position < _collection.GetItems().Count;
	}

	public void Reset() => _position = -1;

	public void Dispose() { }
}