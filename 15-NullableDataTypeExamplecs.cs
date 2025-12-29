using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_lever_2
{
    public class _15_NullableDataTypeExamplecs
    {
        static void Procedure1(string Name, Nullable<int> Age)
        {
            Console.WriteLine("\nName is :" + Name);

            if (Age.HasValue)
            {
                Console.WriteLine("Age is :" + Age.ToString());
            }
            else
            {
                Console.WriteLine("Age is Null");
            }
        }

        static void Procedure2(string Name, int? Age)
        {
            Console.WriteLine("\nName is :" + Name);

            if (Age.HasValue)
            {
                Console.WriteLine("Age is :" + Age.ToString());
            }
            else
            {
                Console.WriteLine("Age is Null");
            }
        }

        static void main(string[] args)
        {

            Procedure1("Mohammed Abu-Hadhoud", null);
            Procedure1("Ali Ahmed", 35);


            Procedure2("Mohammed Abu-Hadhoud", null);
            Procedure2("Ali Ahmed", 35);

            Console.ReadKey();

        }
    }
}

