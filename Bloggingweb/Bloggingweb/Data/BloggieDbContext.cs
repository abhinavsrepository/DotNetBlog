using Bloggingweb.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Bloggingweb.Data
{
    public class BloggieDbContext : DbContext
    {
        public BloggieDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }

        public DbSet<Tag>Tags  { get; set; }




    }
}
