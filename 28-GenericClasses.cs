using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_lever_2
{
    public class _28_GenericClasses
    {
        public class GenericBox<T>
        {
            private T _value;

            public GenericBox(T value)
            {
                _value = value;
            }

            public T GetContent()
            {
                return _value;
            }
        }


        class Program
        {
            static void main()
            {
                // Usage:
                GenericBox<int> intBox = new GenericBox<int>(42);
                Console.WriteLine("Content of intBox: " + intBox.GetContent()); // Outputs: 42


                GenericBox<string> stringBox = new GenericBox<string>("Free Palastine!");
                Console.WriteLine("Content of stringBox: " + stringBox.GetContent()); // Outputs: Free Palastine!
            }
        }
    }
}
