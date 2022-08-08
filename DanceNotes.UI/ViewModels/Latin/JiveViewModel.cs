using DanceNotes.Maui.Common.ViewModels.Base;
using DanceNotes.Maui.Domain.Services;

namespace DanceNotes.UI.ViewModels.Latin;

public class JiveViewModel : DanceStepsViewModel
{
    public JiveViewModel(IDanceService danceService) : base(danceService, "Jive")
    {
    }
}
