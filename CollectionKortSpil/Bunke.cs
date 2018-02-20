using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionKortSpil
{
    public class Bunke
    {
        private Stack<Kort> bunke = new Stack<Kort>();

        public void Tilføjkort(Kort k)
        {
            bunke.Push(k);
        }
        
        public Kort FjernKort()
        {
            if (bunke.Count > 0)
                return bunke.Pop();
            return null;
        }

        public void Vis()
        {
            foreach (var item in bunke)
            {
                Console.WriteLine(item);
            }
        }
    }        
}

