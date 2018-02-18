using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogLib
{
    // DbContext is a base-class from which Blogging Context inherits

    public class BloggingContext : DbContext
    {
        // relisten to 1:57-1:59
        public BloggingContext(DbContextOptions<BloggingContext> options) :base(options)
        {
            // relisten to the segment and understand what is being passed along
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        // Note: there is a method on DbContext and we are overriding that method with our own method
        // 
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //    optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Cohort04EfDemo01;Trusted_Connection=True;");
        //    
        // }
    }

}
