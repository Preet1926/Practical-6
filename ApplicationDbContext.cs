using System.Data.Entity;

namespace ProductCatalogApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("name=DefaultConnection")
        {
            Database.SetInitializer(new CatalogDbInitializer());
        }

        public DbSet<Product> Products { get; set; }
    }

    // Database Initializer - Image Links aur INR Prices ke saath
    public class CatalogDbInitializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            context.Products.Add(new Product
            {
                Name = "Pro Wireless Headphones",
                Category = "Electronics",
                Price = 14999.00m,
                Description = "Active noise cancelling wireless headphones with deep bass.",
                ImageUrl = "https://images.unsplash.com/photo-1505740420928-5e560c06d30e?w=500&q=80"
            });

            context.Products.Add(new Product
            {
                Name = "Ergonomic Mechanical Keyboard",
                Category = "Electronics",
                Price = 8999.00m,
                Description = "RGB backlit tactile mechanical switches.",
                ImageUrl = "https://images.unsplash.com/photo-1587829741301-dc798b83add3?w=500&q=80"
            });

            context.Products.Add(new Product
            {
                Name = "Leather Minimalist Wallet",
                Category = "Accessories",
                Price = 1999.00m,
                Description = "Slim RFID-blocking genuine leather wallet.",
                ImageUrl = "https://images.unsplash.com/photo-1627123424574-724758594e93?w=500&q=80"
            });

            context.Products.Add(new Product
            {
                Name = "Stainless Steel Water Bottle",
                Category = "Home",
                Price = 1299.00m,
                Description = "Vacuum insulated 32oz bottle keeps drinks cold for 24hrs.",
                ImageUrl = "https://images.unsplash.com/photo-1602143407151-7111542de6e8?w=500&q=80"
            });

            base.Seed(context);
        }
    }
}