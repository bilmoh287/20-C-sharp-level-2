using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temprature_Change_Event_Example
{
    public class _01_TempratureChangeEvnevtExample
    {
        public class TempratureChangedEventArgs : EventArgs
        {
            public double OldTemprature { get; }
            public double NewTemprature { get; }
            public double Difference { get; }

            public TempratureChangedEventArgs(double OldTemp, double NewTemp)
            {
                this.OldTemprature = OldTemp;
                this.NewTemprature = NewTemp;
                this.Difference = NewTemp - OldTemp;
            }
        }

        public class Thermostat
        {
            public event EventHandler<TempratureChangedEventArgs> TempratureChanged;

            double OldTemprature;
            double CurrentTemprature;

            public void SetTemprature(int NewTemp)
            {
                if (CurrentTemprature != NewTemp)
                {
                    OldTemprature = CurrentTemprature;
                    CurrentTemprature = NewTemp;

                    OnTempratureChanged();
                }
            }

            private void OnTempratureChanged()
            {
                OnTempratureChanged(new TempratureChangedEventArgs(OldTemprature, CurrentTemprature));
            }

            protected virtual void OnTempratureChanged(TempratureChangedEventArgs e)
            {
                TempratureChanged?.Invoke(this, e);
            }
        }

        public class Display
        {
            public void Subscribe(Thermostat thermostat)
            {
                thermostat.TempratureChanged += HandlerTemperatureChanged;
            }
            public void HandlerTemperatureChanged(object sender, TempratureChangedEventArgs e)
            {
                Console.WriteLine($"\n\nTemperature Changed!");
                Console.WriteLine($"Temperature Changed from {e.OldTemprature}°C");
                Console.WriteLine($"Temperature Changed to {e.NewTemprature}°C");
                Console.WriteLine($"Temperature Diffrence to {e.Difference}°C");
            }
        }

        public class program
        {
            static void main()
            {
                //Console.WriteLine("Hello");
                Thermostat thermostat = new Thermostat();
                Display display = new Display();

                display.Subscribe(thermostat);

                thermostat.SetTemprature(25);
                thermostat.SetTemprature(25);
                thermostat.SetTemprature(30);
                thermostat.SetTemprature(40);
                thermostat.SetTemprature(37);
            }
        }
    }
}
