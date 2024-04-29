using Microsoft.EntityFrameworkCore;
using RazorPagesCrud.Models;
namespace RazorPagesCrud.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }
    }
}
