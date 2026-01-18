using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_lever_2
{
    public class _42_AynchronousTaskClass
    {
        static async Task Main()
        {

            // Create and run an asynchronous task
            Task<int> resultTask = PerformAsyncOperation();

            // Do some other work while waiting for the task to complete
            Console.WriteLine("Doing some other work...");

            int result = await resultTask;
            Console.WriteLine($"Result: {result}");
            Console.ReadLine();
        }

        static async Task<int> PerformAsyncOperation()
        {
            // Simulate an asynchronous operation
            await Task.Delay(2000);

            return 42;
        }
    }
}
