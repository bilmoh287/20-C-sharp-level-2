using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_lever_2
{
    public class _08_Predicate_delegate_function
    {
        class Program
        {
            //define a predicate type for bool retuning(int signature)
            static Predicate<int> IsEvenPrediacte = IsEven;
            static bool IsEven(int num)
            {
                return num % 2 == 0;
            }

            static void main()
            {
                //print using predicate type function
                bool IsEven = IsEvenPrediacte(10);
                if (IsEven)
                {
                    Console.WriteLine("Yes");
                }
                else
                    Console.WriteLine("No");
            }
        }
    }
}
