using ApiCrud.Estudantes;
using Microsoft.EntityFrameworkCore;

namespace ApiCrud.Data;

public class AppDbContext : DbContext
{
    public DbSet<Estudante> Estudantes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Banco.sqlite");
        optionsBuilder.LogTo(Console.Write, LogLevel.Information);
        
        base.OnConfiguring(optionsBuilder);
    }
}