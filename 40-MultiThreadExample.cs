using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_sharp_lever_2
{
    public class _40_MultiThreadExample
    {
        static void Main()
        {

            Console.WriteLine("Starting threads...");

            Thread t1 = new Thread(() => DownloadAndPrint("https://www.cnn.com"));
            t1.Start();
            Console.WriteLine("Thread 1 started...");

            Thread t2 = new Thread(() => DownloadAndPrint("https://www.amazon.com"));
            t2.Start();
            Console.WriteLine("Thread 2 started...");

            Thread t3 = new Thread(() => DownloadAndPrint("https://www.ProgrammingAdvices.com"));
            t3.Start();
            Console.WriteLine("Thread 3 started...\n");


            t1.Join();
            t2.Join();
            t3.Join();


            Console.WriteLine("\nDone all threads finished execution.");
            Console.ReadKey();

        }

        static void DownloadAndPrint(string url)
        {
            string content;

            using (WebClient client = new WebClient())
            {
                // Simulate some work by adding a delay
                Thread.Sleep(100);

                // Download the content of the web page
                content = client.DownloadString(url);
            }

            Console.WriteLine($"{url}: {content.Length} characters downloaded");


        }
    }
}
