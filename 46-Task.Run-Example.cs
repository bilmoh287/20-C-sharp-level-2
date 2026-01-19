using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_sharp_lever_2
{
    internal class _46_Task
    {
        class Program
        {
            static async Task Main()
            {
                Task task1 = Task.Run(() => DownloadFile("Download File1"));
                Task task2 = Task.Run(() => DownloadFile("Download File2"));

                Console.WriteLine("Doing other works!");

                await Task.WhenAll(task1, task2);
                Console.WriteLine("task1 and task2 to are completed!");
                Console.ReadLine();
            }


            static void DownloadFile(string TaskName)
            {
                Console.WriteLine($"{TaskName}: Started");
                Thread.Sleep(3000);
                Console.WriteLine($"{TaskName}: Completed!");
            }

        }
    }
}
