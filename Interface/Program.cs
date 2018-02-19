using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndNLog
{
    class Program
    {

        private static NLog.Logger log = NLog.LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {

            log.Debug("App start");

            IDbFunktioner[] array = new IDbFunktioner[4];
            array[0] = new Dog();
            array[1] = new Uboat();
            array[2] = new Dog();
            array[3] = new Uboat();
            foreach (var item in array)
            {

                item.Gem();
                
            }

            log.Debug("App slut");
        }
    }



    public interface IDbFunktioner
    {

        void Gem();

    }

    class Dog : IDbFunktioner
    {

        public string Navn { get; set; }
        public void Gem()
        {
            Console.WriteLine("Save Dog");
        }


    }

    class Uboat : IDbFunktioner
    {

        public int Nummer { get; set; }
        public double Engine { get; set; }
        public void Gem()
        {
            Console.WriteLine("Save Uboat");
        }
    }
}
