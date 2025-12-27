using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_lever_2
{
    public class _04_DelegateLogerExample
    {
        public class Logger
        {
            public delegate void LogAction(string message);

            LogAction _logAction;
            public Logger(LogAction logger)
            {
                _logAction = logger;
            }

            public void Log(string message)
            {
                _logAction(message);
            }
        }


        public class Program
        {
            //method to log to screen
            public static void LogToScreen(string message)
            {
                Console.WriteLine(message);
            }

            //method to log to Fike
            public static void LogToFile(string message)
            {
                string filename = "Log.txt";
                using (StreamWriter writer = new StreamWriter(filename, true))
                {
                    writer.WriteLine(message);
                }
            }
            static void main(string[] args)
            {
                Logger logToScreen = new Logger(LogToScreen);
                Logger logTofile = new Logger(LogToFile);
                logToScreen.Log("This message will be displayed on the screen");
                logTofile.Log("This message will be logged to the File");

                Console.WriteLine();
            }
        }
    }
}
