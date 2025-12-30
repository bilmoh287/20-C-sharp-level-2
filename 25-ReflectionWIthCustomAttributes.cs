using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace C_sharp_lever_2
{
    public class _25_ReflectionWIthCustomAttributes
    {

        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
        public class MyCustomAttribute : Attribute
        {
            public string Description { get; }


            public MyCustomAttribute(string description)
            {
                Description = description;
            }
        }
        [MyCustom("This is a class attribute")]
        class MyClass
        {
            [MyCustom("This is a method attribute")]
            public void MyMethod()
            {
                // Method implementation
            }
        }

        class Program
        {
            static void main()
            {
                // Get the type of MyClass
                Type type = typeof(MyClass);


                // Get class-level attributes
                object[] classAttributes = type.GetCustomAttributes(typeof(MyCustomAttribute), false);
                foreach (MyCustomAttribute attribute in classAttributes)
                {
                    Console.WriteLine($"Class Attribute: {attribute.Description}");
                }


                // Get method-level attributes
                MethodInfo methodInfo = type.GetMethod("MyMethod");
                object[] methodAttributes = methodInfo.GetCustomAttributes(typeof(MyCustomAttribute), false);
                foreach (MyCustomAttribute attribute in methodAttributes)
                {
                    Console.WriteLine($"Method Attribute: {attribute.Description}");
                }
            }
        }
    }
}
