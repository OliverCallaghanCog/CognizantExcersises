using System.Diagnostics;

class Program {
    static void Main(string[] args) {
        Stopwatch stopwatch = Stopwatch.StartNew();
        SchoolProgram.StartFunc();
        stopwatch.Stop();
        Console.WriteLine($"\nMAIN EXIT : Time taken to execute: {stopwatch.Elapsed.TotalMilliseconds} ms");
    }
}