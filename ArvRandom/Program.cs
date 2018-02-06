using System;

namespace ArvRandom
{
    class Program
    {
        static void Main(string[] args)
        {

            UdvidetRandom r = new UdvidetRandom();
            Console.WriteLine(r.NextBool());

        }
    }
    
    class UdvidetRandom : System.Random
    {
        public bool NextBool()
        {
            return this.Next(1, 1002) < 500;

        }
    }


}

