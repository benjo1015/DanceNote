using DanceNotes.Maui.Common.ViewModels.Base;
using DanceNotes.Maui.Domain.Services;

namespace DanceNotes.UI.ViewModels.Ballroom;

public class WaltzViewModel : DanceStepsViewModel
{
    public WaltzViewModel(IDanceService danceService) : base(danceService, "Waltz")
    {
    }
}
