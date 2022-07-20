namespace DanceNotes.Maui.Models;

public class DanceCategory : IModel
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Category { get; set; }

    public string Description { get; set; }

    public string ImageUrl { get; set; }

    public IEnumerable<DanceStep> DanceSteps { get; set; }
}
