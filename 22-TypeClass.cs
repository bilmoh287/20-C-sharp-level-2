using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_lever_2
{
    internal class _22_TypeClass
    {
        static void main()
        {
            Type myType = typeof(string);


            Console.WriteLine("Type Information:");
            Console.WriteLine($"Name: {myType.Name}");
            Console.WriteLine($"Full Name: {myType.FullName}");
            Console.WriteLine($"Is Class: {myType.IsClass}");


            Console.ReadLine();
        }
    }
}
