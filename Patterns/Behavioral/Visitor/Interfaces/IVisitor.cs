using PatternsSandbox.Patterns.Behavioral.Visitor.Implementations;

namespace PatternsSandbox.Patterns.Behavioral.Visitor.Interfaces;

public interface IVisitor<out T>
{
    T Visit(Circle c);
    T Visit(Square s);
    T Visit(Triangle t);
}