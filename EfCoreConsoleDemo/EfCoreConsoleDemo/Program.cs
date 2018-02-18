using BlogLib;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EfCoreConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Blog myBlog = new Blog
            // {
            //    Url = "bcalearn.tech",
            //    Rating = 5
            // };

            //using (var db = new BloggingContext())
            //{
                // first we find a specific blog
            //    var myBlog = db.Blogs
            //        .Include(b=> b.Posts)
            //        .FirstOrDefault(b => b.BlogId == 2);

            //    for (int i = 0; i < 10000; i++)
            //    {


                // then we add the blog info so it gets tied to the post
            //    var myPost = new Post
            //    {
            //        Blog = myBlog,   // the post contains a blog-object to be tied to a specific blog
            //        BlogId = myBlog.BlogId, // the post has to be tied to a specific blogId
            //        Title = $"Post Number {i}!",
            //        Content = $"<h1>This is the {i}'th Post</h1>"

            //    };

            //    db.Posts.Add(myPost);
            //    }
                // db.Blogs.Add(myBlog);
                // ZZZ --- Restart Entity Framerwork at 1:19
            //    db.SaveChanges();

            }


            // return to video @29:56
            Console.WriteLine("Hello World!");
        }
    }
}
