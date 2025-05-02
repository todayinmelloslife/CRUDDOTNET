using Microsoft.EntityFrameworkCore;
using Dogs.Models;

namespace Dog.Data;

// Define o contexto do banco de dados para a aplicação.
public class DogContext : DbContext 
{
    // Define o conjunto de dados para os modelos de cães.
    public DbSet<DogModel> Dogs { get; set; }

    // Configura o banco de dados SQLite.
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source=dogs.sqLite;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}

