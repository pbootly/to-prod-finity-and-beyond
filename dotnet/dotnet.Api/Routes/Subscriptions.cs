namespace dotnet.Api.Routes;

public static class Subscriptions {
  public static IEndpointRouteBuilder
  MapSubscriptionRoutes(this IEndpointRouteBuilder app) {
    app.MapPost("/subscriptions", Subscribe);
    return app;
  }

  private static async Task Subscribe(HttpContext context) {
    if (!context.Request.HasFormContentType) {
      context.Response.StatusCode = 400;
      return;
    }

    var form = await context.Request.ReadFormAsync();
    var name = form["name"];
    var email = form["email"];

    if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email)) {
      context.Response.StatusCode = 400;
      return;
    }

    context.Response.StatusCode = 200;
  }
}
