```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4460/23H2/2023Update/SunValley3) (Hyper-V)
Intel Xeon Platinum 8370C CPU 2.80GHz, 1 CPU, 2 logical cores and 1 physical core
.NET SDK 8.0.403
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI
  DefaultJob : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX-512F+CD+BW+DQ+VL+VBMI


```
| Method                 | Mean     | Error    | StdDev   | Gen0   | Completed Work Items | Lock Contentions | Gen1   | Allocated |
|----------------------- |---------:|---------:|---------:|-------:|---------------------:|-----------------:|-------:|----------:|
| UsingHttpClient        | 418.7 μs | 24.17 μs | 71.27 μs | 0.9766 |               1.4717 |           0.0039 |      - |  44.69 KB |
| UsingHttpClientFactory | 154.5 μs |  7.82 μs | 23.05 μs | 1.4648 |               1.0000 |           0.0117 | 0.9766 |  36.47 KB |
