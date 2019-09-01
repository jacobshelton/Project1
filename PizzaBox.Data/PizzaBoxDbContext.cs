using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Models;

namespace PizzaBox.Data
{
  public class PizzaBoxDbContext : DbContext
  {
    public DbSet<Crust> Crusts { get; set; }
    public DbSet<Size> Sizes { get; set; }
    public DbSet<Topping> Toppings { get; set; }
    public DbSet<Pizza> Pizzas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
      builder.UseSqlServer("server=localhost;initial catalog=Project1Db;user id=sa;password=Password12345;");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Crust>().HasKey(c => c.ID);
        builder.Entity<Crust>().HasIndex(c => c.Name).IsUnique();

        builder.Entity<Size>().HasKey(s => s.ID);
        builder.Entity<Size>().HasIndex(s => s.Name).IsUnique();

        builder.Entity<Topping>().HasKey(t => t.ID);
        builder.Entity<Topping>().HasIndex(t => t.Name).IsUnique();

        builder.Entity<Pizza>().HasKey(t => t.ID);
        builder.Entity<Pizza>().HasIndex(t => t.Name).IsUnique();

    }
  }
}