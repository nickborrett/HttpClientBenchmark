namespace HttpClientBenchmark;

public class ClientUsingHttpClientFactory(IHttpClientFactory httpClientFactory)
{
    public async Task<string> GetAsync(string url)
    {
        using var httpClient = httpClientFactory.CreateClient(nameof(ClientUsingHttpClientFactory));
        var response = await httpClient.GetAsync(url);
        return await response.Content.ReadAsStringAsync();
    }
}