using System;

namespace EFForSQLie
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new BloggingContext())
            {
                Blog blog = new Blog(){Url = "ryanpham.vn"};
                db.Blogs.Add(blog);
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All blogs in database:");
                foreach (var b in db.Blogs)
                {
                    Console.WriteLine(" - {0}", b.Url);
                }
            }
        }
    }
}
