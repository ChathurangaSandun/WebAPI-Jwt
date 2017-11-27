using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebApplication7.Models
{
    public class BookContext : IdentityDbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}