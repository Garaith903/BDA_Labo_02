using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDA_Labo_01
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DemoLabo1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            connection.Open();

            SqlCommand cmd = new SqlCommand("SELECT FullName, BirthDate, Remark, Description FROM dbo.StudentCourse JOIN  dbo.Student ON dbo.Student.ID = dbo.StudentCourse.StudentID JOIN dbo.Course ON dbo.StudentCourse.CourseID = dbo.Course.Id", connection);

            cmd.ExecuteNonQuery();
     
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                System.Console.WriteLine(reader["FullName"]);

            }

            reader.Close();
            connection.Close();
        }
    }
}
