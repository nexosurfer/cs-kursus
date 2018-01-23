using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLokke
{
    class Program
    {
        static void Main(string[] args)
        {
            

            for (int a = 1; a < 11; a++)

            {
                for (int b = 1; b < 11; b++)
                {

                    string tal = (a * b).ToString();
                    if ((a * b) < 11)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else
                        Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(tal.PadLeft(5));
                }

                Console.WriteLine("\n");


            }


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
