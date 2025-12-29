using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_lever_2
{
    public class _16_NullableExampleWithLambdaExpression
    {
        static void main(string[] args)
        {

            // Separate lambda functions
            Action<string, int?> HasValueLambda = (string name, int? age) =>
            {
                Console.WriteLine("=== Using HasValue Method ===");
                if (name != null)
                    Console.WriteLine($"Name is: {name}");
                else
                    Console.WriteLine("Name is: null");

                // Version 1: Using HasValue property
                if (age.HasValue)
                {
                    Console.WriteLine($"Age is: {age.Value}");
                }
                else
                {
                    Console.WriteLine("Age is: null");
                }
                Console.WriteLine(new string('-', 40));
            };

            Action<string, int?> NullCoalescingLambda = (string name, int? age) =>
            {
                Console.WriteLine("=== Using Null-Coalescing Operator ===");
                Console.WriteLine($"Name is: {name ?? "null"}");
                Console.WriteLine($"Age is: {age?.ToString() ?? "null"}");
                Console.WriteLine(new string('-', 40));
            };

            // Start with empty delegate
            Action<string, int?> CombinedDelegate = null;

            // Use += to assign both lambda functions to the same delegate
            CombinedDelegate += HasValueLambda;
            CombinedDelegate += NullCoalescingLambda;

            // Test the combined delegate - it will execute both methods
            Console.WriteLine("=== Testing Combined Delegate (Both Methods) ===");
            Console.WriteLine("\nTest 1: Normal values");
            CombinedDelegate("John Doe", 25);

            Console.WriteLine("\nTest 2: Null age");
            CombinedDelegate("Jane Smith", null);

            Console.WriteLine("\nTest 3: Null name");
            CombinedDelegate(null, 30);

            Console.WriteLine("\nTest 4: Both null");
            CombinedDelegate(null, null);

            // You can also call individual lambda functions separately
            Console.WriteLine("\n=== Testing Individual Lambda Functions ===");
            Console.WriteLine("\nCalling HasValueLambda only:");
            HasValueLambda("Alice Brown", 28);

            Console.WriteLine("\nCalling NullCoalescingLambda only:");
            NullCoalescingLambda("Charlie Wilson", 35);

        }
    }
}
