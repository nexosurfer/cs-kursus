using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare
{
    class Program
    {
        static void Main(string[] args)
        {

            Hund[] hunde = new Hund[4];
            hunde[0] = new Hund() { Alder = 10, Navn = "Fido" };
            hunde[1] = new Hund() { Alder = 5, Navn = "Lady" };
            hunde[2] = new Hund() { Alder = 3, Navn = "Droppy" };
            hunde[3] = new Hund() { Alder = 11, Navn = "Wulff" };
            Array.Sort(hunde);
            foreach (var item in hunde)
            {

                Console.WriteLine(item.Navn);

            }

        }
    }    

}
