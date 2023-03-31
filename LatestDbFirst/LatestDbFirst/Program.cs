using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatestDbFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var dbContext = new PlutoDbContext();
            /*  courses =  dbContext.GetCourses();
            foreach (var c in courses)
            {
                Console.WriteLine(c.Title);
              Console.WriteLine(c.Description);
                Console.WriteLine(c.FullPrice);
                Console.WriteLine(c.Level);
            } */

             var course = new Cours();
             course.Level = CourseLevel.Biginner; 
        }
    }
}
