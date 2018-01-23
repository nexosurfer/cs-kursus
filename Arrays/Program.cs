using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {


            DateTime tid = DateTime.Now;
            Console.WriteLine("Klokken er:");
            Console.WriteLine(tid.ToString("hh.mm.ss"));

            int[] tal = { 1, 2, 3, 4 };
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(tal[i]);
            }
        

            int [] MdLøn = {10000,20000, 15000, 20000, 30000, 15000 };
            Double sum = 0;
            Array.Sort(MdLøn);
            for (int i = 0; i < MdLøn.Length; i++)
            {
                sum += MdLøn[i];

            }

            double gns = sum / MdLøn.Length;
            for (int i = 0; i < MdLøn.Length; i++)

            {

                Console.WriteLine(MdLøn[i]);
                
            }

            Console.WriteLine("Gennemsnit " + gns.ToString("N2"));
            foreach (int i in MdLøn) Console.Write(i + " ");
                       

                if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
