using PatternsSandbox.Patterns.Behavioral.Visitor.Interfaces;

namespace PatternsSandbox.Patterns.Behavioral.Visitor.Implementations;

public sealed class Visitor : IVisitor<string>
{
    public string Visit(Circle _) => "Circle handled";
    public string Visit(Square _) => "Square handled";
    public string Visit(Triangle _) => "Triangle handled";
}