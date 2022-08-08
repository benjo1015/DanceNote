using DanceNotes.Maui.Common.ViewModels.Base;
using DanceNotes.Maui.Domain.Services;

namespace DanceNotes.UI.ViewModels.Latin;

public class PasoDobleViewModel : DanceStepsViewModel
{
    public PasoDobleViewModel(IDanceService danceService) : base(danceService, "Paso Doble")
    {
    }
}
