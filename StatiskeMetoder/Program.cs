using System;

namespace StatiskeMetoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ArealBeregninger.BeregnArealFirkant(10, 10));
            Console.WriteLine(ArealBeregninger.BeregnArealCirkel(10));
        
        }

    }
}   static class ArealBeregninger
    {

    public static double BeregnArealFirkant(double h, double b)
    {

        return h * b;

    }

    public static double BeregnArealCirkel(double r)
    {

        return Math.Pow(r, 2) * System.Math.PI;
    }
}

