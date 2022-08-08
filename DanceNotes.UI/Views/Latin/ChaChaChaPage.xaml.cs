using DanceNotes.UI.ViewModels.Latin;

namespace DanceNotes.UI.Views.Latin;

public partial class ChaChaChaPage : ContentPage
{
	public ChaChaChaPage(ChaChaChaViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}