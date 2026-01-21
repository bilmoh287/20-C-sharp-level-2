using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace C_sharp_lever_2
{
    public class _30_ReadFromRegistry
    {
        class Program
        {
            static void main()
            {
                // Specify the Registry key and path
                string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\YourSoftware";
                string valueName = "YourValueName";

                try
                {
                    // Read the value from the Registry
                    string value = Registry.GetValue(keyPath, valueName, null) as string;


                    if (value != null)
                    {
                        Console.WriteLine($"The value of {valueName} is: {value}");
                    }
                    else
                    {
                        Console.WriteLine($"Value {valueName} not found in the Registry.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
