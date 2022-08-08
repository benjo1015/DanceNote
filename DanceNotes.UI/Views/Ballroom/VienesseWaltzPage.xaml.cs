using DanceNotes.UI.ViewModels.Ballroom;

namespace DanceNotes.UI.Views.Ballroom;

public partial class VienesseWaltzPage : ContentPage
{
	public VienesseWaltzPage(ViennesseWaltzViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}