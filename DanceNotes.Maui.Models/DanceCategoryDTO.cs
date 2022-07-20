namespace DanceNotes.Maui.Models;

public class DanceCategoryDTO
{
    public string Name { get; set; }

    public string Category { get; set; }

    public string Description { get; set; }

    public string ImageUrl { get; set; }

    public IEnumerable<DanceStepDTO> DanceSteps { get; set; }
}
