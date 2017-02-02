using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS03
{
    class Television
    {
        public bool isOn { get; set; }
        public int Channel { get; set; }
        public int Volume { get; set; }

        public void Power(bool PowerSwitch)
        {

            isOn = PowerSwitch;

            if (isOn == true)
            {
                Channel = 1;
                Volume = 15;
            }

            else if (isOn == false)
            {
                Channel = 0;
                Volume = 0;
            }
        }

        public void ChangeChannel(int value)
        {
            if (isOn == true)
            {
                if (value > 0 && value < 999)
                {
                    Channel = value;
                }

                else
                {
                    Console.WriteLine("Channel [0] is not available.", value);
                }
            }
        }

        public void VolumeUp()
        {
            if (Volume <= 50 && isOn == true)
            {
                Volume++;
            }
        }

        public void VolumeDown()
        {
            if (Volume >= 0 && isOn == true)
            {
                Volume--;
            }
        }

        public void Display()
        {
            Console.WriteLine("Power: " + isOn);
            Console.WriteLine("Channel: " + Channel);
            Console.WriteLine("Volume: " + Volume);
            Console.WriteLine();

        }