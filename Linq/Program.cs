using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] g = { 1, 5, 6, 4, 8, 2, 1 };

            var res = from u in g where u > 4 orderby u select u;
            foreach (var item in res)

            {
                Console.WriteLine(item);
            }

        }
    }
}
