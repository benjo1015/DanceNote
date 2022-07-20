namespace DanceNotes.Core.Database;

public class DatabaseFactory
{
    public string GetDatabasePath(string databaseName)
    {
        string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

        return Path.Combine(documentsPath, databaseName);
    }
}
