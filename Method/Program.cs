using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {

            int res = LægSammen(5, 2);
            Console.WriteLine(res);

            double res2 = BeregnAreal(5);
            Console.WriteLine(res2);

            Udskriv("Dette er en test");

            int[] løn = { 10000, 5000, 30000 };
            double gns = Gennemsnit(løn);
            Console.WriteLine(gns);


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }

        static int LægSammen(int a, int b)
        {

            return a + b;
        }

        static double BeregnAreal(double radius)

        {
            
            return(radius * radius) * 3.1415;

        }

        static void Udskriv(string text)
        {

            Console.WriteLine(text);
           
            
        }

        static double Gennemsnit(int[] månedsløn)

        {
            double sum = 0;
            for (int i = 0; i < månedsløn.Length; i++)
            {
                sum += månedsløn[i];
            }
            return sum / månedsløn.Length;

        }

    }
}
