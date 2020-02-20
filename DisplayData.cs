using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;



namespace DojoBDD
{
    class DisplayData
    {
        public void DisplayAllStudents()
        {
            DatabaseSingleton database = DatabaseSingleton.Instance;
            List<string> allStudents = database.AllStudent;
            foreach (string studentName in allStudents)
            {
                Console.WriteLine(studentName);
            }
        }
    }
}
