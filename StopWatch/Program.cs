using System;
using System.Diagnostics; 
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopw = new Stopwatch();
            stopw.Start();
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(2);
            }
            stopw.Stop();
            Console.WriteLine(" Time elapsed:  "+ stopw.Elapsed);
        }
    }
}
    
