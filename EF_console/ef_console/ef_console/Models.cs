using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef_console
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string Name { get; set; }

        public virtual List<Post> Posts { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }

    public class BloggingContext : DbContext
    {
        public BloggingContext (): base("BlogEntities"){}
	    
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }

    public class BlogDBSeedDatabase : DropCreateDatabaseAlways<BloggingContext>
    {
        protected override void Seed(BloggingContext db)
        {
            Blog b = new Blog();
            b.Name = "My Fourth Blog";
            Post p = new Post();
            p.Title = "My First Post";
            p.Content = "First post in fourth blog";
            b.Posts.Add(p);
            
            try
            {
                db.Posts.Add(p);
                db.Blogs.Add(b);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);                
            }
        }
    }
}
