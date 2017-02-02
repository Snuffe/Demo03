using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS04
{
    class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        public void SetName(string value)
        {
            Name = value;
        }

        public void SetSpeed(int value)
        {
            if (value < 250)
            {
                Speed = value;
            }
            else
            {
                Speed = 250;
            }
        }

        public void SetTyres(int value)
        {
            if (value > 0 && value < 7)
            {
                Tyres = value;
            }
        }

        public void PrintData()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Speed: " + Speed);
            Console.WriteLine("Tyres: " + Tyres);
        }

    }
}