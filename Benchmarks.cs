using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;

namespace HttpClientBenchmark;

[MemoryDiagnoser]
[ThreadingDiagnoser]
public class Benchmarks
{
    private readonly IServiceCollection services = new ServiceCollection();

    public Benchmarks()
    {
        services.AddHttpClient<ClientUsingHttpClient>()
            .ConfigurePrimaryHttpMessageHandler(() => new EmptyHttpMessageHandler());

        services.AddHttpClient<ClientUsingHttpClientFactory>()
            .ConfigurePrimaryHttpMessageHandler(() => new EmptyHttpMessageHandler());

        services.AddTransient<ClientUsingHttpClientFactory>();            
    }

    [Benchmark]
    public async Task UsingHttpClient()
    {
        var serviceProvider = services.BuildServiceProvider();
        var clientUsingHttpClient = serviceProvider.GetRequiredService<ClientUsingHttpClient>();
        await clientUsingHttpClient.GetAsync("https://www.google.com");
    }

    [Benchmark]
    public async Task UsingHttpClientFactory()
    {
        var serviceProvider = services.BuildServiceProvider();
        var clientUsingHttpClientFactory = serviceProvider.GetRequiredService<ClientUsingHttpClientFactory>();
        await clientUsingHttpClientFactory.GetAsync("https://www.google.com");
    }
}