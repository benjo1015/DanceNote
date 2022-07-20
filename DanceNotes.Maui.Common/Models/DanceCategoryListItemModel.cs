using DanceNotes.Maui.Models;

namespace DanceNotes.Maui.Common.Models;

public class DanceCategoryListItemModel : List<DanceStepsListItemModel>
{
    public DanceCategoryListItemModel(DanceCategory danceCategory, List<DanceStepsListItemModel> danceSteps) : base(danceSteps)
    {
        _name = danceCategory?.Name;
        _description = danceCategory.Description;
        _imageURL = danceCategory.ImageUrl;
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

    private string _imageURL;
    public string ImageURL
    {
        get => _imageURL;
        set
        {
            _imageURL = value;
        }
    }

    private string _description;
    public string Description
    {
        get => _description;
        set
        {
            _description = value;
        }
    }

}

