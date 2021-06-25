using Microsoft.AspNetCore.Hosting;

// ConfigureServicves
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMemoryCache();

// Configure
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapGet("/", async (HttpContext context) =>
{
    if (!context.Request.Query.ContainsKey("to")
        || !int.TryParse(context.Request.Query["to"], out var to))
    {
        to = 10000;
    }

    var primes = Enumerable.Range(2, to).Where(x => !Enumerable.Range(3, x / 2).Any(y => x % y == 0)).ToArray();
    await context.Response.WriteAsync(string.Join(", ", primes));
});

await app.RunAsync();

public record TheApiModel(string Target = "World");