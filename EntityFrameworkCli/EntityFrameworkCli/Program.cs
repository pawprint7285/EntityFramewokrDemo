using System;
using BookLib;
using System.Linq;

namespace EntityFrameworkCli
{
    class Program
    {
        static void Main(string[] args)
        {
            Blog newBlog = new Blog
            {
                Url = "myblog.com",
                Rating = 5,
                Posts = new System.Collections.Generic.List<Post>()
            };


            Console.WriteLine("Hello World!");
        }
    }
}
