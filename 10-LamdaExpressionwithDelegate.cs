using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_lever_2
{
    public class _10_LamdaExpressionwithDelegate
    {
        class Program
        {
            // deligate that represent an operation.
            delegate int Operation(int x, int y);
            // A functtion that takes a delegate as parameter and invokes it.
            static void ExecuteOperation(int x, int y, Operation operation)
            {
                int result = operation(x, y);
                Console.WriteLine($"result : {result}");
            }

            // A functtion that takes a Func as parameter and invokes it.
            static void ExecuteOperation(int x, int y, Func<int, int, int> operation)
            {
                int result = operation(x, y);
                Console.WriteLine($"result : {result}");
            }

            // A Method that perform addition.
            static int Add(int x, int y)
            {
                return x + y;
            }
            // A Method that perform substraction.
            static int Sub(int x, int y)
            {
                return x - y;
            }
            static void main()
            {
                // use sub and add method with the delegate
                Operation add = Add;
                Operation sub = Sub;

                ExecuteOperation(10, 20, add); // pass delegate as an arguemnet
                ExecuteOperation(10, 20, sub); // pass delegate as an arguemnet

                //now we use Func and Lambda expression.
                Func<int, int, int> Addition = (x, y) => x + y;
                Func<int, int, int> Substraction = (x, y) => x - y;

                Console.WriteLine();
                ExecuteOperation(20, 30, Addition); // pass lambda expression as an arguemnet
                ExecuteOperation(20, 30, Substraction); // pass lambda expression as an arguemnet

                Console.ReadLine();

            }
        }
    }
}
