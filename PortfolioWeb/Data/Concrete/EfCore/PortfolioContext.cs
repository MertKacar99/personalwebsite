using System.Security.Cryptography.Xml;
using Microsoft.EntityFrameworkCore;
using PortfolioWeb.Entity;

namespace PortfolioWeb.Data.Concrete 
{
    public class PortfolioContext:DbContext
    { 
        public PortfolioContext(DbContextOptions<PortfolioContext> options) : base(options)
        {
        }



        public DbSet<Post> Posts { get; set; }
        public DbSet<IReference> References { get; set; }
        public DbSet<Tag> Tags { get; set; } 

    }
}