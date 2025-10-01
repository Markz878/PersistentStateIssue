using BlazorApp4.Client;

namespace BlazorApp4;

public class CounterServerService : ICounterService
{
    public async Task<CounterState> GetCountAsync()
    {
        Console.WriteLine("CounterServerService.GetCountAsync");
        await Task.Delay(100);
        return new CounterState() { Count = Random.Shared.Next(100, 200) };
    }
}
