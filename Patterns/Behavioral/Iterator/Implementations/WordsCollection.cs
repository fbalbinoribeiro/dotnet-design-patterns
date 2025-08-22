using System.Collections;

namespace PatternsSandbox.Patterns.Behavioral.Iterator.Implementations;

public sealed record WordsCollection : IEnumerable<string>
{
	private readonly List<string> _items = [];

	public void Add(string item) => _items.Add(item);

	public IEnumerator<string> GetEnumerator() => new AlphabeticalOrderIterator(this);
	public IEnumerator<string> GetSizeEnumerator() => new StringSizeIterator(this);

	IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

	public List<string> GetItems() => _items;
}