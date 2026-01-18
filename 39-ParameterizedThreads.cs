using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_sharp_lever_2
{
    public class _39_ParameterizedThreads
    {
        static void Main()
        {
            // Note that your program is the main thread.


            // Create a new thread and start it
            Thread t = new Thread(() => ThreadMethod1("Thread1"));
            t.Start();

            // Create a new thread and start it
            Thread t2 = new Thread(() => ThreadMethod2("Thread2"));
            t2.Start();

            // Make the Main thread wait untill the child thread finishes
            t.Join();
            t2.Join();

            // Main thread continues its execution
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Main Thread: " + i);
                Thread.Sleep(1000); // Sleep for 1 second
            }
            Console.ReadKey();
        }


        static void ThreadMethod1(string ThreadName)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"\t{ThreadName} Method1: " + i);
                Thread.Sleep(1000);
            }
        }

        static void ThreadMethod2(string ThreadName)
        {
            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine($"\t{ThreadName} Method2: " + i);
                Thread.Sleep(1000);
            }
        }
    }
}
