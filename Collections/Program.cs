using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            List<By> city = new List<By>();
            city.Add("Berlin");
            city.Add("Tokyo");

            foreach (var navn in city)
            {
                Console.WriteLine(navn);
            }




        }

    }

}
