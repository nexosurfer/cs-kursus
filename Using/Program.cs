using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Using
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StreamReader stream = System.IO.File.OpenText("dyrenavne.txt"))
            {
                while (stream.Peek() != -1)

                {
                    var l = stream.ReadLine();
                    Console.WriteLine(l.ToUpper());
                }

            }

           
        }
    }

   
}
