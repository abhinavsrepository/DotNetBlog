using Bloggingweb.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Bloggingweb.Data
{
    //db context is a class
    public class BloggieDbContext : DbContext
    {
        public BloggieDbContext(DbContextOptions options) : base(options)
        {
        }
        //entity framework use thing to create database table 
        //dbset
        public DbSet<BlogPost> BlogPosts { get; set; }

        public DbSet<Tag>Tags  { get; set; }




    }
}
