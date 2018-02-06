using System;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person() { Efternavn = "Poulsen", Fornavn = "Hans" };
            Elev e = new Elev() { Efternavn = "Hansen", Fornavn = "Per", KlasseLokale = "A" };
            Instruktør i = new Instruktør() { Efternavn = "Pedersen", Fornavn = "Niels", NøgleId = 1 };
            Console.WriteLine("Person: " + p.FuldtNavn());
            Console.WriteLine("Elev: " + e.FuldtNavn());
            Console.WriteLine("Instruktør: " + i.FuldtNavn());

        }
    }

    public class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public string FuldtNavn(){
            return $"{Fornavn} {Efternavn}";

        }
    }

    public class Elev : Person {
        public string KlasseLokale { get; set; }
    }

    public class Instruktør : Person {
        public int NøgleId { get; set; }
    }

}
