using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace EFForSQLie
{
    public class Blog
    {
        public int BlogID { get; set; } 
        public string Url { get; set; }
        public virtual List<Post> Post { get; set; }
    }

    public class Post
    {
        public int PostID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogID { get; set; }
        public virtual Blog Blog { get; set; }
    }

    public class BloggingContext: DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
       
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
           optionsBuilder.UseSqlite("Data Source = Blogging.db");
       }
    }
}