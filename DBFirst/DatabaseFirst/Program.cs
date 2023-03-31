using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contex = new SampleDbEntities1();
            var student = new Student2()
            {
                StdId = 2,
                StdName = "Dhananjay Khamkar",
                StdPh = 7895644550,
                StdAdd = "Pune"
            };
            contex.Student2.Add(student);
            contex.SaveChanges();


        }
    }
}
