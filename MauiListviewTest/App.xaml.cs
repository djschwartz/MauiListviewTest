namespace MauiListviewTest;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(MyListView), typeof(MyListView));

		MainPage = new AppShell();
	}
}
