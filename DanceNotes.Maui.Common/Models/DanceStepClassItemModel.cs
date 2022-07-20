namespace DanceNotes.Maui.Common.Models;

public class DanceStepClassItemModel : List<DanceStepsListItemModel>
{
    public DanceStepClassItemModel(string name, List<DanceStepsListItemModel> danceSteps) : base(danceSteps)
    {
        _name = name;
    }

    private string _name;
    public string Name
    {
        get => _name;
        set
        {
            _name = value;
        }
    }
}
