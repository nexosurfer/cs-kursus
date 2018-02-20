using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int> MinFunc = () => 2 * 2;
            Console.WriteLine(MinFunc());

            Func<int, int> MinFunc2 = i => i * i;
            Console.WriteLine(MinFunc2(3));

            int[] values = { 4, 2, 74, 1, 6, 22, 60 };
            int[] res = Array.FindAll(values, i => i < 10);
            
        

        }
    }
}
