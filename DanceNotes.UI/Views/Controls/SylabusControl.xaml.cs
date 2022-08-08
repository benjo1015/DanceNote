using DanceNotes.Maui.Common.Models;
using System.Collections.ObjectModel;

namespace DanceNotes.UI.Views.Controls;

public partial class SylabusControl : ContentView
{
	public SylabusControl()
	{
		InitializeComponent();
	}

    public static readonly BindableProperty LogoProperty = BindableProperty.Create(
        nameof(Logo),
        typeof(ImageSource),
        typeof(SylabusControl),
        propertyChanged: (b, o, n) =>
        {
            ((SylabusControl)b).Logo = ((ImageSource)n);
        });

    public ImageSource Logo
    {
        get => (ImageSource)GetValue(LogoProperty);
        set => SetValue(LogoProperty, value);
    }

    ////public static readonly BindableProperty NameProperty = BindableProperty.Create(
    ////    nameof(Name),
    ////    typeof(string),
    ////    typeof(SylabusControl),
    ////    defaultBindingMode: BindingMode.TwoWay,
    ////    propertyChanged: (b, o, n) =>
    ////    {
    ////        ((SylabusControl)b).Name = ((string)n);
    ////    });

    ////public string Name
    ////{
    ////    get => (string)GetValue(NameProperty);
    ////    set => SetValue(NameProperty, value);
    ////}

    ////public static readonly BindableProperty DanceClassesProperty = BindableProperty.Create(
    ////nameof(DanceClasses),
    ////typeof(ObservableCollection<DanceStepClassItemModel>),
    ////typeof(SylabusControl), 
    ////defaultBindingMode: BindingMode.TwoWay,
    ////propertyChanged: (b, o, n) =>
    ////{
    ////    ((SylabusControl)b).DanceClasses = ((ObservableCollection<DanceStepClassItemModel>)n);
    ////});

    ////public ObservableCollection<DanceStepClassItemModel> DanceClasses
    ////{
    ////    get => (ObservableCollection<DanceStepClassItemModel>)GetValue(DescriptionProperty);
    ////    set => SetValue(DescriptionProperty, value);

    ////}

    ////public static readonly BindableProperty DescriptionProperty = BindableProperty.Create(
    ////    nameof(Description),
    ////    typeof(string),
    ////    typeof(SylabusControl),
    ////    defaultBindingMode: BindingMode.TwoWay,
    ////    propertyChanged: (b, o, n) =>
    ////    {
    ////        ((SylabusControl)b).Description = ((string)n);
    ////    });

    ////public string Description
    ////{
    ////    get => (string)GetValue(DescriptionProperty);
    ////    set => SetValue(DescriptionProperty, value);
    ////}

}