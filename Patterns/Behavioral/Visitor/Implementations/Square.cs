using PatternsSandbox.Patterns.Behavioral.Visitor.Interfaces;

namespace PatternsSandbox.Patterns.Behavioral.Visitor.Implementations;

public sealed class Square : IShape
{
    public T Accept<T>(IVisitor<T> visitor) => visitor.Visit(this);
}