using System.Net.Http.Json;

namespace BlazorApp4.Client;

public class CounterClientService(IHttpClientFactory httpClientFactory) : ICounterService
{
    public async Task<CounterState> GetCountAsync()
    {
        Console.WriteLine("CounterClientService.GetCountAsync");
        CounterState? result = await httpClientFactory.CreateClient("Client").GetFromJsonAsync<CounterState>("api/counterstate");
        ArgumentNullException.ThrowIfNull(result);
        return result;
    }
}
