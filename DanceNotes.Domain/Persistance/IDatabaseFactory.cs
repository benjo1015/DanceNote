namespace DanceNotes.Domain.Persistance;

public interface IDatabaseFactory
{
    string GetDatabasePath(string databaseName);
}
