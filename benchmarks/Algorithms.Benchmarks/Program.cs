using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Algorithms.Benchmarks;

internal static class Program
{
    public static void Main(string[] args) =>
        BenchmarkRunner.Run<InfrastructureSmokeBenchmark>();
}

[MemoryDiagnoser]
public class InfrastructureSmokeBenchmark
{
    private readonly int[] _values = Enumerable.Range(0, 1_000).ToArray();

    [Benchmark(Baseline = true)]
    public long SumWithLoop()
    {
        long sum = 0;
        foreach (int value in _values)
        {
            sum += value;
        }

        return sum;
    }
}
