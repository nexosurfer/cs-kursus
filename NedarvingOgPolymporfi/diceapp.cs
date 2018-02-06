using System;
using System.Collections.Generic;
using System.Text;

namespace NedarvingOgPolymporfi
{
    public class dice
    {

        public class Terning
        {
            private static System.Random rnd;
            private int værdi;

            public int Værdi
            {
                get
                {
                    return this.værdi;
                }
                set
                {
                    if (value < 0 || value > 6)
                        value = 1;
                    this.værdi = value;

                }
            }

            public virtual void Skriv()
            {
                Console.WriteLine("[" + this.Værdi + "]");
            }

            public void Ryst()
            {
                this.Værdi = rnd.Next(1, 7);
            }

            public Terning()
            {
                this.Ryst();
            }

            public Terning(int værdi)
            {
                this.Værdi = værdi;
            }

            static Terning()
            {
                rnd = new Random();
            }

        }

        public class LudoTerning : Terning
        {
            public bool ErGlobus()
            {
                return this.Værdi == 3;
            }

            public bool ErStjerne()
            {
                return this.Værdi == 5;
            }

            public LudoTerning() : base()
            { }

            public LudoTerning (int værdi) : base(værdi)
            { }

            public override void Skriv()
            {
                switch (this.Værdi)
                {
                    case 3:
                        Console.WriteLine("S");
                        break;
                    case 5:
                        Console.WriteLine("G)");
                        break;
                    default:
                        base.Skriv();
                        break;
                }
            }
        }
    }
}
