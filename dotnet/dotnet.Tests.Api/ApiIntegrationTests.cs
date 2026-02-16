using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;

namespace dotnet.Tests.Api;

public class ApiIntegrationTests : IClassFixture<WebApplicationFactory<Program>> {
  private readonly WebApplicationFactory<Program> _factory;

  public ApiIntegrationTests(WebApplicationFactory<Program> factory) {
    _factory = factory;
  }

  [Fact]
  public async Task Get_HealthCheck_ReturnsOkAndEmptyBody() {
    var client = _factory.CreateClient();

    var response = await client.GetAsync("/health_check");

    Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    var body = await response.Content.ReadAsStringAsync();
    Assert.Empty(body);
  }

  [Fact]
  public async Task Subscribe_Returns_a_200_for_valid_form_data() {
    var client = _factory.CreateClient();
    var body = "name=le%20guin&email=ursula_le_guin%40gmail.com";
    var content = new StringContent(body);
    content.Headers.ContentType =
        new System.Net.Http.Headers.MediaTypeHeaderValue(
            "application/x-www-form-urlencoded");
    var response = await client.PostAsync("/subscriptions", content);
    Assert.Equal(HttpStatusCode.OK, response.StatusCode);
  }

  [Fact]
  public async Task Subscribe_Returns_a_400_for_missing_data() {
    var client = _factory.CreateClient();
    var test_cases =
        new[] { ("name=le%20guin", "missing the email"),
                ("email=ursula_le_guin%40gmail.com", "missing the name"),
                ("", "missing both name and email") };

    foreach (var (body, description) in test_cases) {
      var content = new StringContent(body);
      content.Headers.ContentType =
          new System.Net.Http.Headers.MediaTypeHeaderValue(
              "application/x-www-form-urlencoded");
      var response = await client.PostAsync("/subscriptions", content);
      Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
    }
  }
}
