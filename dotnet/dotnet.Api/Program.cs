using dotnet.Api.Routes;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddHealthChecks();

var app = builder.Build();

if (app.Environment.IsDevelopment()) {
  app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapHealthRoutes();
app.MapSubscriptionRoutes();

app.Run();

public partial class Program {}
