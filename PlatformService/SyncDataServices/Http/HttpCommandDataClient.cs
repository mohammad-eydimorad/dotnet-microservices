using System.Text;
using System.Text.Json;
using PlatformService.Dtos;

namespace PlatformService.SyncDataServices.Http
{
  public class HttpCommandDataClient : ICommandDataClient
  {
    private readonly HttpClient _httpClient;
    private readonly IConfiguration _configuration;

    public HttpCommandDataClient(HttpClient httpClient, IConfiguration configuration)
    {
      this._httpClient = httpClient;
      this._configuration = configuration;
    }

    public async Task SendPlatformToCommand(PlatformReadDto platform)
    {
      var httpContent = new StringContent(
        JsonSerializer.Serialize(platform),
        Encoding.UTF8,
        "application/json"
      );
      HttpResponseMessage response = await _httpClient.PostAsync($"{_configuration["CommandService"]}", httpContent);
      if (response.IsSuccessStatusCode)
      {
        Console.WriteLine("---> Sync post to CommandService was OK!");
      }
      else
      {
        Console.WriteLine("---> Sync post to CommandService was NOT OK!");
      }
    }
  }
}