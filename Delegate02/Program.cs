﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate02
{
    class Program
    {

       
        static void Main(string[] args)
        {
            int res = 0;
            res = Beregner(1, 1, Plus);
            res = Beregner(1, 1, Minus);
            Console.WriteLine(Beregner(10, 10, Plus));
            Console.WriteLine(Beregner(10, 10, Minus));
            Console.WriteLine(Beregner(10, 10, Divider));
            Console.WriteLine(Beregner(10, 10, Gange));
            
        }

        public static int Beregner(int a, int b,Func<int, int, int> funktion)
        {
            return funktion(a, b);
        }

        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }
        public static int Divider(int a, int b)
        {
            return a / b;
        }
        public static int Gange(int a, int b)
        {
            return a * b;
        }

    }
}
