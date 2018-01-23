using System;

namespace Module04_ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {


            int MdLøn1 = 1000;
            int MdLøn2 = 2000;
            int MdLøn3 = 1500;
            int MdLøn4 = 2500;

            int sum = MdLøn1 + MdLøn2 + MdLøn3 + MdLøn4;
            double gns = sum / 5;
            Console.WriteLine(gns.ToString("N2"));

            

            
               
           
            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
