using BenchmarkDotNet.Running;

namespace ArrayVsListPerformanceBenchmark;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Performance Benchmark between Array versus List");
        var result = BenchmarkRunner.Run(typeof(TestBenchmark));
    }
}