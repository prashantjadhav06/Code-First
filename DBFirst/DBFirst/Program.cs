using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirst
{
    internal class Program
    {
        static void Main(string[] args, int _)
        {
            var contex = new SampleDbEntities1();
            var sampleStdDb = new SampleStdDB()
            {
                Stdid = 1,
                StdtName = "Prashant Jadhav",
                StdPh = 7798456315,
                StdAdd = "Kolhapur",

            };
            contex.SampleStdDBs.Add(sampleStdDb);
            contex.SaveChanges();
        }
    }
}
