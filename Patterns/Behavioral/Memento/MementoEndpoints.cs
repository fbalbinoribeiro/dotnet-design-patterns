using PatternsSandbox.Patterns.Behavioral.Memento.Implementations;

namespace PatternsSandbox.Patterns.Behavioral.Memento;

public static class MementoEndpoints
{
	public static void MapEndpoints(this IEndpointRouteBuilder routes)
	{
		routes.MapGet("/memento", () =>
		{
			var editor = new TextEditor();
			var history = new History();

			editor.Write("Hello, ");
			history.Backup(editor);

			editor.Write("World!");
			history.Backup(editor);

			editor.Write(" This is a Memento pattern example.");
			history.Backup(editor);

			history.Undo(editor);
			history.Undo(editor);
			history.Redo(editor);

			return Results.Ok(new { Text = editor.Text.ToString() });
		})
		.WithName("Memento")
		.WithOpenApi();
	}
}