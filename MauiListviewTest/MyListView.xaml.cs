using App.ViewModels;

namespace MauiListviewTest;

public partial class MyListView : ContentPage
{
	public MyListView(MyListviewViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

}

