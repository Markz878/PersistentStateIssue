using Microsoft.AspNetCore.Components;

namespace BlazorApp4.Client.Pages;

public partial class Counter(ICounterService counterService) : ComponentBase
{
    [PersistentState(AllowUpdates = true, RestoreBehavior = RestoreBehavior.SkipLastSnapshot)]
    public CounterState? State { get; set; }

    protected override async Task OnInitializedAsync()
    {
        State ??= await counterService.GetCountAsync();
    }

    private void IncrementCount()
    {
        if (State is not null)
        {
            State.Count++;
        }
    }
}