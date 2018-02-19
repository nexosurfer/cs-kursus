using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Person> row1 = new List<Person>();
            row1.Add(new Person() { Id = 1, Navn = "Mads" });
            row1.Add(new Person() { Id = 2, Navn = "Ida" });
            row1.Add(new Person() { Id = 3, Navn = "Emil" });
            foreach (var item in row1)

            {

                Console.WriteLine(item.Navn);

            }

            Dictionary<int, Person> row2 = new Dictionary<int, Person>();
            row2.Add(1, new Person() { Id = 1, Navn = "Mads" });
            row2.Add(2, new Person() { Id = 2, Navn = "Ida" });
            row2.Add(3,new Person() { Id = 3, Navn = "Emil" });
            var p = row2[3];
            Console.WriteLine(p.Navn);
        }
    }


}
