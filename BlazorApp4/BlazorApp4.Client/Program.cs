using BlazorApp4.Client;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

WebAssemblyHostBuilder builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped<ICounterService, CounterClientService>();
builder.Services.AddHttpClient("Client", config =>
{
    config.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
}).AddStandardResilienceHandler();
await builder.Build().RunAsync();
