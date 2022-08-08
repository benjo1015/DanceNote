using DanceNotes.UI.ViewModels.Latin;

namespace DanceNotes.UI.Views.Latin;

public partial class RhumbaPage : ContentPage
{
	public RhumbaPage(RhumbaViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}