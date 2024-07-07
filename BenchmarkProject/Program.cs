using BenchmarkDotNet.Running;

namespace BenchmarkProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            var summary = BenchmarkRunner.Run<BenchmarkDemo>();
        }
    }
}
