using System;
using System.Diagnostics;

namespace ConsoleNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var dt = DateTime.Now.Date;
            var nextDt = DateTime.Now;

            for (int i = 1; i <= 14; i++)
            {
                nextDt = dt.AddDays(4 * i);
                Console.WriteLine(nextDt);
            }

            stopwatch.Stop();

            Console.WriteLine(Environment.NewLine + $"Elapsed Time(ms):{stopwatch.ElapsedMilliseconds}");
            Console.ReadLine();
        }
    }
}