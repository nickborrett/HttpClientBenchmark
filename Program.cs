using BenchmarkDotNet.Running;

namespace HttpClientBenchmark;

public class Program
{
    public static void Main(string[] args)
    {
        BenchmarkRunner.Run<Benchmarks>();
    }
}