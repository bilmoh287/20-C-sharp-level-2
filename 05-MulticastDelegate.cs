using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_lever_2
{
    public class _05_MulticastDelegate
    {
        public delegate void MyDelegate(string message);


        class Program
        {
            static void main()
            {
                MyDelegate myDelegate = Method1;
                myDelegate += Method2;


                myDelegate("Hello, world!");


                myDelegate -= Method1;
                myDelegate("Another message.");
            }


            static void Method1(string message)
            {
                Console.WriteLine("Method1: " + message);
            }


            static void Method2(string message)
            {
                Console.WriteLine("Method2: " + message);
            }
        }
    }
}
