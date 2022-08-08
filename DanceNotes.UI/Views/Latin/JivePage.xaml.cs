using DanceNotes.UI.ViewModels.Latin;

namespace DanceNotes.UI.Views.Latin;

public partial class JivePage : ContentPage
{
	public JivePage(JiveViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}