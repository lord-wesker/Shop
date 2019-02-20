namespace Shop.Web.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Entities;
    using Shop.Web.Models;

    public class DataContext : IdentityDbContext<User>
    {
        public DbSet<Product> Products { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }

}
