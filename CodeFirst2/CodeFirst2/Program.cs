using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst2
{
    internal class Program
    {
        public class Employee
        {
            [Key]
            public int EmpId { get; set; }
            public string EMpName { get; set; }
            public long EmpPhon { get; set; }
            public int EmpAge { get; set; }
        }
         public class EmpDbContext : DbContext
        {
            public DbSet<Employee> Emps { get; set; }
        }

        static void Main(string[] args)
        {
        }
    }
}
