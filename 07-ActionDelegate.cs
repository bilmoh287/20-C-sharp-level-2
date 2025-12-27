using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_lever_2
{
    public class _07_ActionDelegate
    {
        class Program
        {
            static void ain()
            {
                // Declare and initialize Action delegates with regular methods

                Action parameterlessAction = ParameterlessMethod;
                Action<int> actionWithIntParameter = ActionWithIntParameterMethod;
                Action<string, int> actionWithMultipleParameters = ActionWithMultipleParametersMethod;

                // Invoking the actions

                parameterlessAction();
                actionWithIntParameter(42);
                actionWithMultipleParameters("Hello, World!", 100);
                Console.ReadKey();

            }

            // Regular methods to be used with Action delegates

            static void ParameterlessMethod()
            {
                Console.WriteLine("This is a parameterless action.");
            }

            static void ActionWithIntParameterMethod(int x)
            {
                Console.WriteLine($"Action with int parameter: {x}");
            }

            static void ActionWithMultipleParametersMethod(string str, int num)
            {
                Console.WriteLine($"Action with string and int parameters: {str}, {num}");
            }
        }
    }
}
