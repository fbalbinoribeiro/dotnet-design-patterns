using PatternsSandbox.Patterns.Behavioral.Strategy.Interfaces;

namespace PatternsSandbox.Patterns.Behavioral.Strategy.Implementations;

public readonly record struct AddStrategy : IStrategy
{
	public short Execute(byte firstNumber, byte secondNumber) => (short)(firstNumber + secondNumber);
}