var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "This is ASP.NET Creating for UI based on web application");

app.Run();
