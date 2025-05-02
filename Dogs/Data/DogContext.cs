using Microsoft.EntityFrameworkCore;
using Dogs.Models;

namespace Dog.Data;

public class DogContext : DbContext 
{
public DbSet<DogModel> Dogs { get; set; }

 protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
 {
     if (!optionsBuilder.IsConfigured)
     {
         optionsBuilder.UseSqlite("Data Source=dogs.sqLite;");
        base.OnConfiguring(optionsBuilder);
     }
 }

}

