using DanceNotes.Maui.Common.Models;
using DanceNotes.Maui.Common.ViewModels.Base;
using DanceNotes.Maui.Domain.Services;
using DanceNotes.Maui.Domain.ViewModels;
using System.Collections.ObjectModel;

namespace DanceNotes.UI.ViewModels;

public abstract class DanceStepsViewModel : NotifyPropertyChanged
{
    private readonly IDanceService _danceService;
    private string _classname;

    public DanceStepsViewModel(IDanceService danceService, string classname)
    {
        _danceService = danceService;
        _classname = classname;
        Initialize();
    }

    private string _name;
    public string Name 
    {
        get 
        {
            return _name;
        }
        set 
        { 
            SetProperty(ref _name, value);
        } 
    }

    private string _description;
    public string Description 
    {
        get 
        {
            return _description;
        } 
        set 
        {
            SetProperty(ref _description, value);
        } 
    }

    public ObservableCollection<DanceStepClassItemModel> DanceClasses { get; private set; }

    public void Initialize()
    {
        DanceClasses = new ObservableCollection<DanceStepClassItemModel>();
        var steps = _danceService.GetAllSteps(_classname).Result;
        if (steps != null)
        {
            this.Name = steps.Name;
            this.Description = steps.Description;
            foreach (var step in steps.DanceSteps.Select(x => new DanceStepsListItemModel(x)).ToList().GroupBy(x => x.Class).ToList())
            {
                DanceClasses.Add(new DanceStepClassItemModel(step.Key, step.ToList()));
            }
        }
    }
}
