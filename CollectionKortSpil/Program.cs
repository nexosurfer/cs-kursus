using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionKortSpil
{
    class Program
    {
        static void Main(string[] args)
        {

            Bunke b = new Bunke();
            b.Tilføjkort(new Kort() { Kulør = "Spar", Værdi = 2 });
            b.Tilføjkort(new Kort() { Kulør = "Hjerter", Værdi = 9 });
            b.Tilføjkort(new Kort() { Kulør = "Ruder", Værdi = 3 });
            b.Tilføjkort(new Kort() { Kulør = "Spar", Værdi = 10 });
            b.Tilføjkort(new Kort() { Kulør = "Hjerter", Værdi = 5 });
            b.Tilføjkort(new Kort() { Kulør = "Ruder", Værdi = 7 });
            b.Vis();

            var k = b.FjernKort();
            Console.WriteLine();
            Console.WriteLine(k);
            Console.WriteLine();
            b.Vis();
        }
    }
}
