using Immediate.Handlers.Shared;

namespace Normal;

[Handler]
public static partial class GetWeatherForecast
{
	private static readonly string[] s_summaries =
	[
		"Freezing",
		"Bracing",
		"Chilly",
		"Cool",
		"Mild",
		"Warm",
		"Balmy",
		"Hot",
		"Sweltering",
		"Scorching",
	];

	public sealed record Query;

	public sealed record Response(DateOnly Date, int TemperatureC, string? Summary)
	{
		public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
	}

	private static ValueTask<IEnumerable<Response>> HandleAsync(
		Query _,
		CancellationToken token
	)
	{
		token.ThrowIfCancellationRequested();

		var forecast = Enumerable.Range(1, 5)
			.Select(index =>
				new Response
				(
					DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
					Random.Shared.Next(-20, 55),
					s_summaries[Random.Shared.Next(s_summaries.Length)]
				)
			);

		return ValueTask.FromResult(forecast);
	}
}
