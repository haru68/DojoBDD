using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace DojoBDD
{
    class DatabaseSingleton
    {
        public SqlConnection Connection { get; set; }
        private static DatabaseSingleton singleton = null;

        private DatabaseSingleton()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"PC-HARU\SQLEXPRESS";
            builder.InitialCatalog = "SchoolInfos";
            builder.IntegratedSecurity = true;
            Connection = new SqlConnection(builder.ConnectionString);
            Connection.Open();
        }

        public static DatabaseSingleton Instance
        {
            get
            {
                if (singleton == null)
                {
                    singleton = new DatabaseSingleton();
                }
                return singleton;
            }
        }

        public List<string> AllStudent
        {
            get
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Connection;
                cmd.CommandText = "SELECT firstName FROM Students";
                List<string> studentsInfo = new List<string>();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            String studentName = Convert.ToString(reader["firstName"]);
                            studentsInfo.Add(studentName);
                        }
                    }
                }
                return studentsInfo;
            }
        }

        

    }
}
