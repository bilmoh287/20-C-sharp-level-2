#define koko
using System;
using System.Diagnostics;


public class MyClass
{
    [Conditional("DEBUG")]
    public void DebugMethod()
    {
        Console.WriteLine("Debug method executed.");
    }

    public void NormalMethod()
    {
        Console.WriteLine("Normal method executed.");
    }

    [Conditional("koko")]
    public static void LogTrace(string message)
    {
        Console.WriteLine($"[TRACE] {message}");
    }
}

class Program2
{
    static void main()
    {
        MyClass myClass = new MyClass();


        // Call the methods
        myClass.DebugMethod();  // This will only be executed in DEBUG builds
        myClass.NormalMethod(); // This will always be executed

        MyClass.LogTrace("This trace message will only be included if TRACE_ENABLED is defined.");
        Console.WriteLine("Rest of the program.");

        Console.ReadLine();
    }
}
