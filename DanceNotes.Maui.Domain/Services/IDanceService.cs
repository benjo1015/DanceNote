using DanceNotes.Maui.Models;

namespace DanceNotes.Maui.Domain.Services;

public interface IDanceService
{
    Task<DanceCategory> GetAllSteps(string danceclass);
}
