using DanceNotes.UI.ViewModels.Latin;

namespace DanceNotes.UI.Views.Latin;

public partial class PasoDoblePage : ContentPage
{
	public PasoDoblePage(PasoDobleViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}