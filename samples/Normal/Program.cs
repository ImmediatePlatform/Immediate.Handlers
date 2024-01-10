using Normal;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddBehaviors();
builder.Services.AddHandlers();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	_ = app.UseSwagger();
	_ = app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet(
		"/weatherforecast",
		async (GetWeatherForecast.Handler handler, [AsParameters] GetWeatherForecast.Query query) => await handler.HandleAsync(query)
	)
	.WithName("GetWeatherForecast")
	.WithOpenApi();

app.Run();
