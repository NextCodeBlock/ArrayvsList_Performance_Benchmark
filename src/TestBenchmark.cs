using BenchmarkDotNet.Attributes;

namespace ArrayVsListPerformanceBenchmark;

public class TestBenchmark
{
    [Params(10, 100)] 
    public int Count;

    [Benchmark]
    public int[] ArrayPerformance()
    {
        int[] numbers = new int[Count];
        for (int i = 0; i < Count; i++)
            numbers[i] = i;

        return numbers;
    }

    [Benchmark]
    public List<int> ListPerformanceWithCapacity()
    {
        List<int> numbers = new List<int>(Count);
        for (int i = 0; i < Count; i++)
            numbers.Add(i);
        return numbers;
    }

    [Benchmark]
    public List<int> ListPerformanceWithoutCapacity()
    {
        List<int> numbers = new List<int>();
        for (int i = 0; i < Count; i++)
            numbers.Add(i);
        return numbers;
    }
}