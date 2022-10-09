using System;
using System.Collections.Generic;


namespace Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();
            students.Add(new Student("Ivan ", "Ivanov", "000587"));
            students.Add(new Student("Ivan ", "Petrov", "006381"));

            foreach(Student student in students)
            {
                Console.WriteLine(student.ToString());
            }

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Petro", "Vasilovich", 1590,10));

            foreach(Worker worker in workers)
            {
                Console.WriteLine(worker.ToString());
            }

            Console.ReadLine();
        }
    }
}
