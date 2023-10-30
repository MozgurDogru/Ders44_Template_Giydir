using Microsoft.EntityFrameworkCore;

namespace Ders44_Template_Giydir.Models
{
    public class NorthwindContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");

            var configuration = builder.Build();

            optionsBuilder.UseSqlServer(configuration["ConnectionStrings:iakademi47Connection"]);
        }

        public DbSet<Product> Products { get; set; }

    }
}
