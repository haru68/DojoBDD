using System;
using System.Collections.Generic;
using System.Text;

namespace DojoBDD
{
    class Teacher : AbstractPerson
    {
        private Teacher(string name, List<AbstractPerson> persons) : base(name, persons)
        { }

        public static Teacher CreateTeacher(string name, List<AbstractPerson> persons)
        {
            Teacher teacher = new Teacher(name, persons);
            return teacher;
        }
    }
}
