using System;
using System.Collections.Generic;
using System.Text;

namespace DojoBDD
{
    public abstract class AbstractPerson
    {
        public String Name { get; private set; }
        public Int32 Id { get; private set; }

        public List<AbstractPerson> Persons { get; private set; } = new List<AbstractPerson>();

        protected AbstractPerson(string name)
        {
            Name = name;
        }

        protected AbstractPerson(string name, List<AbstractPerson> persons) : this(name)
        {
            Persons = persons;
        }

        public static AbstractPerson Create(string name, List<AbstractPerson> persons = null)
        {
            if (persons == null)
            {
                return Student.CreateStudent(name);
            }
            else
            {
                return Teacher.CreateTeacher(name, persons);
            }
        }
    }
}
