using System;


public class MyClass2
{
    [Obsolete("This method is marked as obsolete, and will be deprecated in the future.")]
    public void Method1()
    {
        Console.WriteLine("This method is marked as obsolete, and will be deprecated in the future.");
    }


    public void Method2()
    {
        Console.WriteLine("This is the recommended method to use.");
    }
}


class Program3
{
    static void main()
    {
        MyClass2 myObject = new MyClass2();


        // Deprecated method usage
        myObject.Method1(); // Generates a compiler warning


        // New method usage
        myObject.Method2();


        Console.ReadLine();
    }
}
