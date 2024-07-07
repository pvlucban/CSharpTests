using BenchmarkDotNet.Attributes;

namespace BenchmarkProject
{
    [MemoryDiagnoser]
    public class BenchmarkDemo
    {
        [Benchmark]
        public void Method1()
        {
            for (int i = 0; i < 1000; i++)
            {
                var x = Math.Sqrt(i);
            }
        }

        [Benchmark]
        public void Method2()
        {
            for (int i = 0; i < 1000; i++)
            {
                var x = i * i;
            }
        }
    }
}
