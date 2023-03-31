using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    internal class Program
    {
        public class Emp
        {
            public int empId { get; set; }
            public string empName { get; set; }
            public int empAge { get; set; }
            public long empPh { get; set; }
            public String empAddress { get; set; }
        }

        public class EmpDbContext : DbContext
        {
            public DbSet<Emp> Emps { get; set; }
        }
        
        static void Main(string[] args)
        {

        }
    }
}
