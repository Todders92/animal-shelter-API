using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
        : base(options)
    {
    }

    public DbSet<Animal> Animals { get; set; }
  
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
      .HasData(
          new Animal { AnimalId = 1, Name = "Stitch", Species = "Black Lab", Age = 8, Gender = "Male" },
          new Animal { AnimalId = 2, Name = "Morgan", Species = "Gray Tuxedo", Age = 2, Gender = "Male" },
          new Animal { AnimalId = 3, Name = "Mindy", Species = "Gray Tabby", Age = 2, Gender = "Female" },
          new Animal { AnimalId = 4, Name = "Magic Mike", Species = "Lab Pitbull mix", Age = 3, Gender = "Male" },
          new Animal { AnimalId = 5, Name = "Tigger", Species = "Gray Tabby", Age = 9, Gender = "Male" }
      );
    }
  }
}
