using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Lab_06
{
    internal class Program
    {
        static void Main()
        {

            List<Person> pers = new List<Person>();
            Console.WriteLine("People:");
            pers.Add(new Person("Ivan", 55 ));
            pers.Add(new Person("Petro", 45));
            pers.Add(new Person("Roma", 16));
            foreach (Person people in pers)
            {
                
                Console.WriteLine(people.ToString());
            }


            Console.WriteLine();
            Console.WriteLine("Child:");
            List<Child> child = new List<Child>();
            child.Add(new Child("Peta", 12));
            child.Add(new Child("Vova", 10));
            child.Add(new Child("Yura", 18));
            foreach (Child children in child)
            {
                Console.WriteLine(children.ToString());
            }

            Console.ReadLine();
        }
    }
}
