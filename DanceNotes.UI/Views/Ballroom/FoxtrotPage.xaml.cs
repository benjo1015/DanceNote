using DanceNotes.UI.ViewModels.Ballroom;

namespace DanceNotes.UI.Views.Ballroom;

public partial class FoxtrotPage : ContentPage
{
	public FoxtrotPage(FoxtrotViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}