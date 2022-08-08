using DanceNotes.Maui.Common.ViewModels.Base;
using DanceNotes.Maui.Domain.Services;

namespace DanceNotes.UI.ViewModels.Ballroom;

public class FoxtrotViewModel : DanceStepsViewModel
{
    public FoxtrotViewModel(IDanceService danceService) : base(danceService, "Foxtrot")
    {
    }
}
