using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_sharp_lever_2
{
    internal class _49_Paraller
    {
        static List<string> urls = new List<string>
    {
        "https://www.cnn.com",
        "https://www.amazon.com",
    };


        static void Main()
        {

            // Use Parallel.ForEach to download the web pages concurrently
            Parallel.ForEach(urls, url =>
            {
                DownloadContent(url);

            });


            Console.WriteLine("Done!");
            Console.ReadKey();
        }


        static void DownloadContent(string url)
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

