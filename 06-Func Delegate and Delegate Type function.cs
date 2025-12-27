using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_lever_2
{
    public class _06_Func_Delegate_and_Delegate_Type_function
    {
        class Program
        {
            //define a deligate type for int retuning(int signature)
            delegate int CalcDelegate(int num);

            //define a Func delegate to squere a number
            static Func<int, int> Squere = SquereMethod;

            //define a function to squere a number
            static int SquereMethod(int num)
            {
                return num * num;
            }

            //define a function to sum a number
            static int SumMethod(int num)
            {
                return num + num;
            }

            static void main()
            {
                int result;
                //print using delegate type function
                CalcDelegate calc = new CalcDelegate(SquereMethod);
                result = calc(5);
                Console.WriteLine("Function delegate Squere Result is : " + result);

                CalcDelegate calc2 = new CalcDelegate(SumMethod);
                result = calc2(5);
                Console.WriteLine("Function delegate Sum Result is : " + result);

                //print squere using Func
                result = Squere(5);
                Console.WriteLine("Func Squere Result is : " + result);
            }

        }
    }
}
