using DanceNotes.Maui.Common.ViewModels.Base;
using DanceNotes.Maui.Domain.Services;

namespace DanceNotes.UI.ViewModels.Ballroom;

public class QuickStepViewModel : DanceStepsViewModel
{
    public QuickStepViewModel(IDanceService danceService) : base(danceService, "QuickStep")
    {
    }
}
