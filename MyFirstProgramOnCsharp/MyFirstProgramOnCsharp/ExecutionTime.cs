using System;
using System.Diagnostics;
using System.Threading;

namespace MyFirstProgramOnCsharp
{
    internal class ExecutionTime
    {

        public static void FindExecutionTimeOfProgram()
        {
            Stopwatch stopwatch=new Stopwatch();

            stopwatch.Start();

            Task();

            stopwatch.Stop();

            Console.WriteLine($" execution time is {stopwatch.Elapsed.TotalSeconds}");//

        }

        public static void Task()
        {
            Thread.Sleep(1000);
        }

    }
}
