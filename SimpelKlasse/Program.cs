using System;

namespace SimpelKlasse
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            p1.Firstname = "Nicolai";
            p1.Lastname = "Horn Pedersen";
            p1.Birthday = 1975;
            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p1.EstimeretAlder());
            Person p2 = new Person("a", "b", 2000);
            Console.WriteLine(p2.FuldtNavn());
            Console.ReadKey();


        }
    }

    class Person
    {

        public string Firstname;
        public string Lastname;
        public int Birthday;

        public string FuldtNavn()
        {
            return $"{Firstname} {Lastname}";
        }

        public int EstimeretAlder()
        {

            int år = DateTime.Now.Year;
            return år - this.Birthday;

        }
        // Default Construtor
        public Person()
        {

            this.Firstname = "";
            this.Lastname = "";
        }

        //Custom Construtor

        public Person(string efternavn, string fornavn, int fødselsår)
        {

            this.Birthday = fødselsår;
            this.Firstname = fornavn.ToUpper();
            this.Lastname = efternavn.ToUpper();

        }




    }


}
