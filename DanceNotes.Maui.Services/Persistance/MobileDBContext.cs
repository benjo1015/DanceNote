using DanceNotes.Domain.Persistance;
using DanceNotes.Maui.Models;
using DanceNotes.Maui.Services.Persistance.Seed;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace DanceNotes.Maui.Services.Persistance;

public class MobileDbContext : DbContext
{
    private readonly IDatabaseFactory _databaseFactory;

    public DbSet<DanceCategory> DanceCategories { get; set; }

    public MobileDbContext(IDatabaseFactory databaseFactory)
    {
        _databaseFactory = databaseFactory;

        SQLitePCL.Batteries_V2.Init();

        if (Database.EnsureCreated())
        {
            // seed
            DatabaseInitializer.Seed(this);
        }
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var databasePath = _databaseFactory.GetDatabasePath(DanceNotes.Common.Constants.Database.DatabaseName);
        var connection = new SqliteConnectionStringBuilder
        {
            DataSource = databasePath,
            Mode = SqliteOpenMode.ReadWriteCreate,
        };

        optionsBuilder.UseSqlite(connection.ToString());
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DanceCategory>().ToTable(nameof(DanceCategory));
        modelBuilder.Entity<DanceStep>().ToTable(nameof(DanceStep));
    }
}
