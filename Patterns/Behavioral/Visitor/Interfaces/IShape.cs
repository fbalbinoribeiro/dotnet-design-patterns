namespace PatternsSandbox.Patterns.Behavioral.Visitor.Interfaces;

public interface IShape
{
    T Accept<T>(IVisitor<T> visitor);
}