var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

//var port = Environment.GetEnvironmentVariable("PORT")??"8080";
var port = Environment.GetEnvironmentVariable("PORT")??"80";

app.MapGet("/", () =>
{
    app.Logger.LogInformation("Initial Home Get");
    return "GET - Net 6 Running ... 13122022-v1.0.1 CI/CD in KUBERNETES IN AZURE FRANCO VARGAS CHINO v1.0.2 AFORO255";
});

app.MapPost("/", () =>
{
    app.Logger.LogInformation("Initial Home Post");
    return "POST - Net 6 Running ... 06122022-v1.0.0 CI/CD in TRAVIS FRANCO VARGAS v1.0.1 AFORO255";
});

app.Run($"http://0.0.0.0:{port}");

