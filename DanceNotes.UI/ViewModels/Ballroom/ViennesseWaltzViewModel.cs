using DanceNotes.Maui.Common.ViewModels.Base;
using DanceNotes.Maui.Domain.Services;

namespace DanceNotes.UI.ViewModels.Ballroom;

public class ViennesseWaltzViewModel : DanceStepsViewModel
{
    public ViennesseWaltzViewModel(IDanceService danceService) : base (danceService, "Viennese Waltz")
    {
    }
}
