using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS01
{
    class Kiuas
    {
        public bool Onpaalla { get; set; }
        public int Lampotila { get; set; }
        public double Kosteus { get; set; }

        public void LisaaLampoa(int value)
        {
            Lampotila += value;
        }

        public void VahemmanLampoa(int value)
        {
            Lampotila -= value;
        }

        public void Paalla(bool value)
        {
            Onpaalla = value;
        }

        public void LisaaKosteutta(int value)
        {
            Kosteus += value;
        }

        public void VahennaKosteutta(int value)
        {
            Kosteus -= value;
        }

        public void PrintData()
        {
            Console.WriteLine(" __Kiukaan tila__ ");
            Console.WriteLine("Paalla : " + Onpaalla);
            Console.WriteLine("Lampotila : " + Lampotila);
            Console.WriteLine("Kosteus : " + Kosteus);
        }
