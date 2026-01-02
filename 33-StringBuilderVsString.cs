using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_lever_2
{
    public class _33_StringBuilderVsString
    {
        class Program
        {
            static void ConcatenateString(int iterations)
            {
                string res = "";
                for (int i = 0; i < iterations; i++)
                {
                    res += "a";
                }
            }

            static void ConcatenateStringBuilder(int iterations)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < iterations; i++)
                {
                    sb.Append("a");
                }
                string res = sb.ToString();

            }
            static void Main()
            {
                int iterations = 200000;
                Stopwatch stopwatch1 = Stopwatch.StartNew();
                ConcatenateString(iterations);
                stopwatch1.Stop();
                Console.WriteLine("Concatenating staring took : " + stopwatch1.ElapsedMilliseconds);

                Stopwatch stopwatch2 = Stopwatch.StartNew();
                ConcatenateStringBuilder(iterations);
                stopwatch2.Stop();
                Console.WriteLine("Concatenating staring using StringBuilder took : " + stopwatch2.ElapsedMilliseconds);
                Console.ReadKey();
            }
        }

    }
}
