using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Products.Models;
namespace Products.Data
{
    internal class ProductsContext : IdentityDbContext
    {
        public ProductsContext()
        {
        }

        public ProductsContext(DbContextOptions<ProductsContext> options)
    : base(options)
        {
        }
        public DbSet<Models.Products> Products { get; set; }
        public DbSet<categories> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseSqlServer("Data Source=DESKTOP-B1HEDNI\\SQLEXPRESS;Initial Catalog=Products;Integrated Security=True;trust server certificate=True");
        }
    }
}
