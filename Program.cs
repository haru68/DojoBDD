using System;
using System.Collections.Generic;

namespace DojoBDD
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayData display = new DisplayData();
            display.DisplayAllStudents();

            List<AbstractPerson> students = new List<AbstractPerson>
            {
                Student.CreateStudent("Bob"),
                Student.CreateStudent("Franck")
            };

            AbstractPerson teacher = AbstractPerson.Create("Franck", students);

            Console.WriteLine(teacher);
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
