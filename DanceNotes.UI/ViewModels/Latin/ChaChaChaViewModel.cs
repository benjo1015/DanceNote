using DanceNotes.Maui.Common.Models;
using DanceNotes.Maui.Common.ViewModels.Base;
using DanceNotes.Maui.Domain.Services;
using System.Collections.ObjectModel;
using System.Linq;

namespace DanceNotes.UI.ViewModels.Latin;

public class ChaChaChaViewModel : DanceStepsViewModel
{
    public ChaChaChaViewModel(IDanceService danceService) : base(danceService, "ChaChaCha")
    {
    }
}
