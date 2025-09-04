using PatternsSandbox.Patterns.Behavioral.Iterator.Implementations;

namespace PatternsSandbox.Patterns.Behavioral.Iterator;

public static class IteratorEndpoints
{
	public static void MapEndpoints(this IEndpointRouteBuilder routes)
	{
		routes.MapPost("/iterator", (string order) =>
		{
			var collection = new WordsCollection
			{
				"apple",
				"banana",
				"cherry",
				"coconut",
				"mango",
				"grape"
			};

			var result = order switch
			{
				"alphabetical" => ToList(collection.GetEnumerator()),
				"length" => ToList(collection.GetSizeEnumerator()),
				_ => throw new ArgumentException("Invalid order")
			};

			return Results.Ok(result);
		})
		.WithName("Iterator")
		.WithOpenApi(op =>
		{
			var param = op.Parameters.FirstOrDefault(p => p.Name == "order");
			if (param is not null)
			{
				param.Description = "alphabetical, length.";
			}
			return op;
		});

	}

	private static List<string> ToList(IEnumerator<string> enumerator)
	{
		var list = new List<string>();
		while (enumerator.MoveNext())
		{
			list.Add(enumerator.Current);
		}
		return list;
	}
}