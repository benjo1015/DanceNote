using DanceNotes.Maui.Common.ViewModels.Base;
using DanceNotes.Maui.Models;
using System.ComponentModel;
namespace DanceNotes.Maui.Common.Models;

public class DanceStepsListItemModel : NotifyPropertyChanged
{
    public DanceStepsListItemModel(DanceStep danceStep)
    {
        _class = danceStep.Class;
        _name = danceStep.Name;
        _description = danceStep.Description;
    }

    private string _class;
    public string Class
    {
        get => _class;
        set => SetProperty(ref _class, value);
    }

    private string _name;
    public string Name
    {
        get => _name;
        set => SetProperty(ref _name, value);
    }

    private string _description;
    public string Description
    {
        get => _description;
        set => SetProperty(ref _description, value);
    }
}

