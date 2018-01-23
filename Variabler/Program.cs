using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabler
{
    class Program
    {
        static void Main(string[] args)
        {


            int heltal = 10;
            heltal++;
            heltal--;
            heltal += 20;
            Console.WriteLine(heltal);

            double kommatal = 12.5;
            kommatal *= 2;
            Console.WriteLine(kommatal);

            FilTyper ft = FilTyper.csv;
            Console.WriteLine(ft);
            Console.WriteLine((int)ft);

            DateTime dato = DateTime.Now;
            Console.WriteLine(dato.ToString("ddMMyyyy"));
            Console.WriteLine(dato.ToString("d-m-y"));
            Console.WriteLine(dato.ToLongDateString());

            Person p;
            p.id = 1;
            p.navn = "Mikkel";
            Console.WriteLine(p.navn);

            double test = 100;
            Console.WriteLine(test);
            Console.WriteLine(test.ToString());
            Console.WriteLine(test.ToString("N2"));
            Console.WriteLine(test.ToString("N6"));

            DateTime tid = DateTime.Now;
            Console.WriteLine(tid.ToString("hh.mm.ss"));






            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

            
            
        }
    }

    public struct Person
    {
        public int id;
        public string navn;
    }
    public enum FilTyper
    {
        pdf,
        txt,
        csv
    }

    public enum Farver
    {
        Hjerter,
        Ruder,
        Spar,
        Klør
    }

   

}
