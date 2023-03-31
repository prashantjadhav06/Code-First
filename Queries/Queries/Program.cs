
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;
namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            ////LINQ Syntax
            //var query = 
            //    from c in context.Courses
            //    where c.Name.Contains("C#")
            //    orderby c.Name
            //    select c;

            ////foreach (var c in query)
            ////{
            ////    Console.WriteLine(c.Name);
            ////}

            ////Extension Method
            //var courses = context.Courses.
            //    Where(c => c.Name.Contains("C#"))
            //    .OrderBy(c => c.Name);

            //foreach (var course in courses)
            //    Console.WriteLine(course.Name);

            //var query = 
            //    from c in context.Courses
            //    where c.Level == 1 && c.Author.Id == 1
            //    orderby c.Level
            //    select c;

            // for descending order
            //orderby c.level descending


            //Grouping
            //var query =
            //    from c in context.Courses
            //    group c by c.Level
            //    into g
            //    select g;

            //foreach (var group in query)
            //{
            //    Console.WriteLine(group.Key);   
            //}

            //Joins
            //var query =
            //    from c in context.Courses
            //    join a in context.Authors on c.AuthorId equals a.Id
            //    select new { CourseName = c.Name, AuthorName = a.Name };


            //Extension Method
            //var tags = context.Courses
            //    .Where(c => c.Level == 1)
            //    .OrderByDescending(c => c.Name)
            //    .ThenByDescending(c => c.Level)
            //    .SelectMany(c => c.Tags);

            //foreach (var t in tags)
            //{ 
            //        Console.WriteLine(t.Name);
            //}


            //IQueryable
            //IQueryable<Course> courses = context.Courses;
            //var filtered = courses.Where(c => c.Level == 1);
            //foreach( var course in filtered)
            //    Console.WriteLine(course.Name); 

            //IEnumerable<Course> courses = context.Courses;
            //var filtered = courses.Where(c => c.Level == 1);
            //foreach( var course in filtered)
            //    Console.WriteLine(course.Name);

            //Console.ReadLine();


            //Adding new object
            //var course = new Course
            //{
            //    Name = "New Course",
            //    Description = "New Desccription",
            //    FullPrice = 19.95f,
            //    Level = 1,
            //    Author = new Author
            //    { Id = 1, Name = "Prashant Jadhav" }
            //};
            //var author = context.Authors.Single(a => a.Id == 1);
            //var course = new Course
            //{
            //    Name = "New Course 2",
            //    Description = "New Desccription 2",
            //    FullPrice = 19.95f,
            //    Level = 1,
            //    Author = author,
            //};

            //Using foreign Key
            //var course = new Course
            //{
            //    Name = "New Course 2",
            //    Description = "New Desccription 2",
            //    FullPrice = 19.95f,
            //    Level = 1,
            //    AuthorId = 1
            //};
            //context.Courses.Add(course);



            //Udating object
            //var course = context.Courses.Find(5);
            //course.Name = "Prashant";
            //course.AuthorId = 2;

            //Removing the object with cascade delete
            //var course = context.Courses.Find(6);
            //context.Courses.Remove(course);
            //context.SaveChanges(); 


            //using change tracker
            var entries = context.ChangeTracker.Entries();
            foreach (var entry in entries)
            {
                Console.WriteLine(entry.State);
            }

            Console.ReadLine();



             

        }
    }
}
