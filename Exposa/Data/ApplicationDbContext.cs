using Exposa.Models;
using Microsoft.EntityFrameworkCore;

namespace Exposa.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Exposa.Models.Color> Color { get; set; } = default!;
        public DbSet<Exposa.Models.Size> Size { get; set; } = default!;
    }
}
