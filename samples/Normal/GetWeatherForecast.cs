using Immediate.Handlers.Shared;

namespace Normal;

[Handler]
public static partial class GetWeatherForecast
{
	private static readonly string[] Summaries =
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

	public record Query;

	public record Response(DateOnly Date, int TemperatureC, string? Summary)
	{
		public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
	}

	private static Task<IEnumerable<Response>> HandleAsync(
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
					Summaries[Random.Shared.Next(Summaries.Length)]
				)
			);

		return Task.FromResult(forecast);
	}
}
