using DanceNotes.Maui.Common.ViewModels.Base;
using DanceNotes.Maui.Domain.Services;

namespace DanceNotes.UI.ViewModels.Latin;

public class RhumbaViewModel : DanceStepsViewModel
{
    public RhumbaViewModel(IDanceService danceService) : base(danceService, "Rhumba")
    {
    }
}
