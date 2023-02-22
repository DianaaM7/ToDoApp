
using ToDoApp.Models;
using ToDoApp.ViewModels;

namespace ToDoApp.Views;

public partial class ToDoPage : ContentPage
{
	public ToDoPage(ToDoPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

}

