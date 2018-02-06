using System;

namespace PolymorfiDyr
{
    class Program
    {
        static void Main(string[] args)
        {

            Dyr[] dyr = new Dyr[20];
            for (int i = 0; i < 20; i++)
            {
                dyr[i] = Dyr.TilFældigeDyr();

            }

            foreach (var item in dyr)
            {
                item.Signoget();
            }
            
         
        }

        
    }
    
    class Dyr {

        static System.Random rnd = new Random();
        public string Name { get; set; }
        public virtual void Signoget() {
            Console.WriteLine("Jeg er et dyr og hedder " + Name);
        }

        public static Dyr TilFældigeDyr() {

            string sti = @"x:\dyrenavne.txt";
            string[] Names = System.IO.File.ReadAllLines(sti);
            int index = rnd.Next(0, Names.Length);
            if (index % 2 == 0) {
                return new Hund() { Name = Names[index] };
            } else

            {
                return new Kat() { Name = Names[index] };
            }

        }
        
    }

    class Hund : Dyr
    {
        public override void Signoget()
        {
            Console.WriteLine("jeg er en hund og hedder " + Name);
        }

    }

    class Kat : Dyr
    {
        public override void Signoget()
        {
            Console.WriteLine("jeg er en kat og hedder " + Name);
        }


    }
}
