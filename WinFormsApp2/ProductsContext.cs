using Microsoft.EntityFrameworkCore;
using WinFormsApp2;

namespace WinFormsApp2;

public class ProductsContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=products.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
            new Category { CategoryId = 1, Name = "Imetajad" },
            new Category { CategoryId = 2, Name = "Roomajad" },
            new Category { CategoryId = 3, Name = "Linnud" },
            new Category { CategoryId = 4, Name = "Kahepaiksed" });

        modelBuilder.Entity<Product>().HasData(
            new Product { ProductId = 1, CategoryId = 1, Name = "Elevant" },
            new Product { ProductId = 2, CategoryId = 1, Name = "Lõvi" },
            new Product { ProductId = 3, CategoryId = 1, Name = "Rebane" },
            new Product { ProductId = 4, CategoryId = 1, Name = "Ahv" },
            new Product { ProductId = 5, CategoryId = 1, Name = "Eesel" },
            new Product { ProductId = 6, CategoryId = 1, Name = "Gorilla" },
            new Product { ProductId = 7, CategoryId = 1, Name = "Leemur" },
            new Product { ProductId = 8, CategoryId = 1, Name = "Tiiger" },
            new Product { ProductId = 9, CategoryId = 1, Name = "Piison" },
            new Product { ProductId = 10, CategoryId = 1, Name = "Sisalik" },
            new Product { ProductId = 11, CategoryId = 2, Name = "Rästik" },
            new Product { ProductId = 12, CategoryId = 2, Name = "Anakonda" },
            new Product { ProductId = 13, CategoryId = 2, Name = "Kobra" },
            new Product { ProductId = 14, CategoryId = 2, Name = "Boa" },
            new Product { ProductId = 15, CategoryId = 2, Name = "Kilpkonn" },
            new Product { ProductId = 16, CategoryId = 2, Name = "Krokodill" },
            new Product { ProductId = 17, CategoryId = 3, Name = "Hani" },
            new Product { ProductId = 18, CategoryId = 3, Name = "Rähn" },
            new Product { ProductId = 19, CategoryId = 3, Name = "Sinilind" },
            new Product { ProductId = 20, CategoryId = 3, Name = "Pääsuke" },
            new Product { ProductId = 21, CategoryId = 3, Name = "Teder" },
            new Product { ProductId = 22, CategoryId = 3, Name = "Kurg" },
            new Product { ProductId = 23, CategoryId = 3, Name = "Öökull" },
            new Product { ProductId = 24, CategoryId = 4, Name = "Mudakonn" },
            new Product { ProductId = 25, CategoryId = 4, Name = "Kärnkonn" },
            new Product { ProductId = 26, CategoryId = 4, Name = "Brioche" });
    }
}