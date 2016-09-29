using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoLabo1Entities context = new DemoLabo1Entities();

            foreach (var Student in context.Students)
            {
                Console.WriteLine(Student.FullName);
                Console.WriteLine(Student.Birthdate);
                Console.WriteLine(Student.Remark);



            }
            Console.ReadKey();
        }
    }
}
