using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_lever_2
{
    public class _09_LambdaExpression
    {
        class Program
        {
            // finc function using Lambda expression
            static Func<int, int> Squere = X => X * X;

            static Action parameterlessAction = () =>
            {
                Console.WriteLine("This is a parameterless action.");
            };
            static Action<int> actionWithIntParameter = (x) =>
            {
                Console.WriteLine($"Action with int parameter: {x}");

            };
            static Action<string, int> actionWithMultipleParameters = (str, num) =>
            {
                Console.WriteLine($"Action with string and int parameters: {str}, {num}");

            };
            static void main()
            {
                //display the func function using lambda
                int result = Squere(5);
                Console.WriteLine($"Result : {result}");

                //display the Action function using lambda
                Console.WriteLine();
                parameterlessAction();
                actionWithIntParameter(5);
                actionWithMultipleParameters("bilmoh", 10);

                Action ParameterlessInsideMain = () =>
                {
                    Console.WriteLine("This is a parameterless action you can use me without static.");
                };

                ParameterlessInsideMain();
            }
        }
    }
}
