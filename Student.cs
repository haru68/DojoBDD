using System;
using System.Collections.Generic;
using System.Text;

namespace DojoBDD
{
    class Student : AbstractPerson
    {
        private Student(String name) : base(name)
        { }

        public static Student CreateStudent(string name)
        {
            Student student = new Student(name);
            return student;
        }
    }
}
