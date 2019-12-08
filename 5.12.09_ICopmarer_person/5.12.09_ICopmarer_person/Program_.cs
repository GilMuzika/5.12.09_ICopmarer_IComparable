using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._12._09_ICopmarer_person
{
    class Program_
    {
        static void Main(string[] args)
        {

            Person moshe = new Person(47, 187, "Beni");
            Person ksenia = new Person(37, 165, "Christina");
            Person shula = new Person(9, 0.45f, "Dorit");
            Person ariel = new Person(8, 100, "Ariel");
            Person[] gropuPersons = new Person[] {moshe, ksenia, shula, ariel };

            PrintPersonArray(gropuPersons);
            Console.WriteLine("\n------------------------\n");
            Array.Sort(gropuPersons, new PersonCompireByName());
            PrintPersonArray(gropuPersons);

            

            Console.ReadKey();
        }

        private static void PrintPersonArray(Person[] persons)
        {
            foreach (var s in persons) Console.WriteLine(s.ToString());
        }



    }
}
