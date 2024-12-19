namespace HttpClientBenchmark;

public class ClientUsingHttpClient(HttpClient httpClient)
{
    public async Task<string> GetAsync(string url)
    {
        var response = await httpClient.GetAsync(url);
        return await response.Content.ReadAsStringAsync();
    }
}