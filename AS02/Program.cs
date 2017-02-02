using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS02
{
    class Machine
    {
        public int Temperature { get; set; }
        public bool isOn { get; set; }
        public int TimeToWash { get; set; }

        public void Power(bool PowerSwitch)
        {
            isOn = PowerSwitch;
        }

        public void SetTime(int value)
        {
            TimeToWash = value;
        }

        public void SetTemperature(int value)
        {
            Temperature = value;
        }

        public void Display()
        {
            Console.WriteLine("Power: " + isOn);
            Console.WriteLine("Time: " + TimeToWash);
            Console.WriteLine("Temperature: " + Temperature);
            Console.WriteLine();
        }

    }
}
