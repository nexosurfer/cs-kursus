using System;
using System.Text;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace Yatzy
{
    class Program
    {
        static void Main(string[] args)
        {

            YatzyApp1.Terning t1 = new YatzyApp1.Terning();
            //t1.Skriv();
            //t1.Værdi = 4;
            //t1.Skriv();
            //t1.Værdi = 8; //bør ikke kunne ske
            //t1.Skriv();
            //t1.Ryst();
            //t1.Skriv();

            //for (int i = 0; i < 10; i++)
            //{

            //    t1.Ryst();
            //    t1.Skriv();

            //}

            //t1.Ryst(true);
            //t1.Skriv();

            YatzyApp1.Bæger res = new YatzyApp1.Bæger();
            res.Skriv();
                        
            //Console.ReadKey();

            
        }
    }
}
