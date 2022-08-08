using DanceNotes.UI.ViewModels.Ballroom;

namespace DanceNotes.UI.Views.Ballroom;

public partial class WaltzPage : ContentPage
{
	public WaltzPage(WaltzViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}