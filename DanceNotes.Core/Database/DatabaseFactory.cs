using DanceNotes.Domain.Persistance;

namespace DanceNotes.Core.Database;

public class DatabaseFactory : IDatabaseFactory
{
    public string GetDatabasePath(string databaseName)
    {
        string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

        return Path.Combine(documentsPath, databaseName);
    }
}
