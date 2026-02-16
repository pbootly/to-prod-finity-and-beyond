namespace dotnet.Api.Routes;

public static class HealthChecks {
  public static IEndpointRouteBuilder
  MapHealthRoutes(this IEndpointRouteBuilder app) {
    app.MapGet("/health_check", HandleHealthCheck);
    return app;
  }

  private static Task HandleHealthCheck(HttpContext context) {
    context.Response.StatusCode = 200;
    return Task.CompletedTask;
  }
}
