using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_lever_2
{
    internal class _48_Parallel
    {
        static void Main()
        {
            // Define the number of iterations
            int numberOfIterations = 10;


            // Use Parallel.For to execute the loop in parallel
            Parallel.For(0, numberOfIterations, ProcessIteration);


            Console.WriteLine("All iterations completed.");
        }


        static void ProcessIteration(int i)
        {
            Console.WriteLine($"Executing iteration {i} on thread {Task.CurrentId}");
            // Simulate some work
            Task.Delay(1000).Wait();
        }
    }
}
