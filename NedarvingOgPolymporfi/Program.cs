using System;
using static NedarvingOgPolymporfi.dice;

namespace NedarvingOgPolymporfi
{
    class Program
    {
        static void Main(string[] args)
        {

            Terning[] terninger = new Terning[5];
            terninger[0] = new Terning();
            terninger[1] = new Terning();
            terninger[2] = new Terning();
            terninger[3] = new Terning();
            terninger[4] = new Terning();

            foreach (var item in terninger)
            {
                item.Skriv();
            }
        }              
    }

}
