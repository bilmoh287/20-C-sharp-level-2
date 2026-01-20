using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace C_sharp_lever_2
{
    internal class _29_WrittingToRegisrty
    {
        class Program
        {
            static void main()
            {
                // Specify the Registry key and path
                string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\YourSoftware";
                string valueName = "YourValueName";
                string valueData = "YourValueData";


                try
                {
                    // Write the value to the Registry
                    Registry.SetValue(keyPath, valueName, valueData, RegistryValueKind.String);


                    Console.WriteLine($"Value {valueName} successfully written to the Registry.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
