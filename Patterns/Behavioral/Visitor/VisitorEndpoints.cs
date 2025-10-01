using PatternsSandbox.Patterns.Behavioral.Visitor.Implementations;
using PatternsSandbox.Patterns.Behavioral.Visitor.Interfaces;

namespace PatternsSandbox.Patterns.Behavioral.Visitor;

public static class VisitorEndpoints
{
    public static void MapEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapPost("/visitor", (string shape) =>
        {
            IShape shapeElement = shape switch
            {
                "circle" => new Circle(),
                "square" => new Square(),
                "triangle" => new Triangle(),
                _ => throw new ArgumentException("Invalid shape")
            };

            var visitor = new Implementations.Visitor();
            
            return Results.Ok(shapeElement.Accept(visitor));
        })
        .WithName("Visitor")
        .WithOpenApi(op =>
        {
            var param = op.Parameters.FirstOrDefault(p => p.Name == "shape");
            if (param is not null)
            {
                param.Description = "circle, square, triangle.";
            }
            return op;
        });
    }
}
