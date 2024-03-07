namespace AppBindingCommands.Views;
using AppBindingCommands.ViewModels;

public partial class UsuarioView : ContentPage
{
	public UsuarioView()
	{
		InitializeComponent();
		BindingContext = new UsuarioViewModel();
	}
}