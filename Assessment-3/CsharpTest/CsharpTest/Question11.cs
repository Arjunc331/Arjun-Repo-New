using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace csharpTest
{
    public class Quetion11
    {       //display Data from Database to C# application using Nuget Package system.data.sqlclient;
        static void Main(string[] args)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-H8UVFBNG;Initial Catalog=SnadDB;Integrated Security=True"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM employee", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Console.WriteLine(reader.GetValue(i));
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}