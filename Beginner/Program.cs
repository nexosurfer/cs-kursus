using System;


namespace Beginner
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DateTime dato = DateTime.Now;
            Console.WriteLine(dato.ToString("ddMMyyyy"));
            Console.WriteLine(dato.ToString("d-M-y"));
            Console.WriteLine(dato.ToLocalTime());

            char[] bogstav = { 'A', 'B', 'C', 'D' };
            Console.WriteLine("Mit bogstav: " + bogstav[1]);

            int heltal = 10;
            heltal += 20;
            Console.WriteLine(heltal);

            double kommatal = 12.5;
            kommatal++;
            kommatal--;
            kommatal *= 2;
            Console.WriteLine(kommatal);


            Console.WriteLine("Skriv et tal: ");
            int tal = Convert.ToInt16(Console.ReadLine());

            if (tal == 5)

            {

                Console.WriteLine("Korrekt tal!");

            }

            else

            {

                Console.WriteLine("Forkert tal! ");
                
              
            }

            Person p;
            p.id = 1;
            p.alder = 15;
            p.navn = "Per";
            Console.WriteLine(p.navn + "\n" + p.alder);
            
            // Array

            int[] num = { 10, 7, 6, 3, 1, 50, 3 };
            Array.Sort(num);
            foreach (int i in num)
                Console.Write(i + " ");


            string[] alphabet = { "B", "C", "A", "D", "L", "Y", "G", "H", "I", "Z", "K", "E", "O", "N", "M", "P", "X", "R", "S", "T", "U", "V", "W", "Q", "F", "J" };
            Array.Sort(alphabet);
            foreach (string i in alphabet)
                Console.Write(i + "\n" + " ");



            


            Console.ReadKey();


                                    
         // Console.WriteLine("\n" + "Press SpaceKey");
            
        }
        
        public struct Person
        {
            public int id;
            public int alder;
            public string navn;

        }
    }
}