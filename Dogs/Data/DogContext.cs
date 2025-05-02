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
        
     var configuration = new ConfigurationBuilder()
         .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
         .AddJsonFile("appsettings.json")
         .Build();
     optionsBuilder.UseSqlite(configuration.GetConnectionString("DefaultConnection"));
        base.OnConfiguring(optionsBuilder);
     }
 }

}

