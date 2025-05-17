var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello from JDT Hello World!");

app.MapGet("/health", () => Results.Ok("Healthy"));
app.MapGet("/ready", () => Results.Ok("Ready"));

app.Run();