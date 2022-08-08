using DanceNotes.Maui.Common.ViewModels.Base;
using DanceNotes.Maui.Domain.Services;

namespace DanceNotes.UI.ViewModels.Latin;

public class SambaViewModel : DanceStepsViewModel
{
    public SambaViewModel(IDanceService danceService) : base(danceService, "Samba")
    {
    }
}
