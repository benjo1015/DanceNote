using DanceNotes.UI.ViewModels.Ballroom;

namespace DanceNotes.UI.Views.Ballroom;

public partial class QuickStepPage : ContentPage
{
	public QuickStepPage(QuickStepViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}