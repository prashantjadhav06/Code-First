﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst3
{
    internal class Program
    {
        public class Post
        {
            public int Id { get; set; }
            public DateTime DatePublished { get; set; }
            public string Title { get; set; }
            public string Body { get; set; }
        }
        public class BlogDbContex : DbContext
        {
            public DbSet<Post> Posts { get; set; }
        }
        static void Main(string[] args)
        {
        }
    }
}