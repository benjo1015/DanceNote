using DanceNotes.Maui.Common.ViewModels.Base;
using DanceNotes.Maui.Domain.Services;

namespace DanceNotes.UI.ViewModels.Ballroom;

public class TangoViewModel : DanceStepsViewModel
{
    public TangoViewModel(IDanceService danceService) : base(danceService, "Tango")
    {
    }
}
