using DanceNotes.UI.ViewModels.Ballroom;

namespace DanceNotes.UI.Views.Ballroom;

public partial class TangoPage : ContentPage
{
	public TangoPage(TangoViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}