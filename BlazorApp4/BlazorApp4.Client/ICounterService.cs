namespace BlazorApp4.Client;

public interface ICounterService
{
    Task<CounterState> GetCountAsync();
}
