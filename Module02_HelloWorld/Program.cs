using System;

namespace Module02_HelloWorld
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Test");

            Console.Write("1");
            Console.Write("2");
            Console.Write("3");
            Console.Write("4\n");

            for (int antal = 0; antal < 10; antal++)
            {

                Console.Write(antal + 1);
                Console.Write("\n");

            }

            
            
            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("\nPress any key to continue . . . ");
                System.Console.ReadKey();
            }
        }

        static void DebugDemo() {

            int i = 10;
            int u = 20;
            u = u + i;
            string name = "Mikkel";
            System.Console.WriteLine(name);
            string upperName = name.ToUpper();
            System.Console.WriteLine(upperName);

            for (int x = 0; x < 3; x++)
            {
                u += x;
            }

            Test1(5);

        }

        static void Test1(int i)
        {
            i++;
            Test2(i);
        }

        static void Test2(int i)
        {
            i--;
            Test3(i);
        }

        static void Test3(int i)
        {
            i++;
        }
    }
}
