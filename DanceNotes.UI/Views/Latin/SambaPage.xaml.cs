using DanceNotes.UI.ViewModels.Latin;

namespace DanceNotes.UI.Views.Latin;

public partial class SambaPage : ContentPage
{
	public SambaPage(SambaViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}