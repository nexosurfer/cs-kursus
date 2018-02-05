using System;

namespace EgenskaberTrekant
{
    class Program
    {
        static void Main(string[] args)
        {

            Trekant a = new Trekant();
            
            
                       
        }
    }
}
public class Trekant
{
    public int Grundlinje { get; private set; }
    public int Højde { get; private set; }

    public Trekant(int grundlinje, int højde)
    {
        this.Grundlinje = grundlinje;
        this.Højde = højde;

    }

    
    public double Areal {

        get {
            return this.Grundlinje * this.Højde * 0.5;
        }


    }

}


    
