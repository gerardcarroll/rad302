using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ef_console
{
    class Program
    {         
        static void Main(string[] args)
        {
            BloggingContext db = new BloggingContext();

            //Blog b = new Blog();
            //b.Name = "My Third Blog";
            //Post p = new Post();
            //p.Title = "My First Post";
            //p.Content = "Testing";
            //p.BlogId = 1;
            //try
            //{
            //    db.Posts.Add(p);
            //    db.SaveChanges();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);                
            //}
            

            var q = db.Blogs;
            
            foreach (var blog in q)
            {   
                Console.WriteLine("{0}", blog);
            }
            Console.ReadLine();
        }
    }
}
