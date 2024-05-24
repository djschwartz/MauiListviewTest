using CommunityToolkit.Mvvm.Input;
using MauiListviewTest;

namespace App.ViewModels;

public partial class MainPageViewModel {

    public MainPageViewModel() {

    }

    [RelayCommand]
    public void ShowList() {
        Console.WriteLine("--> Navigate to MyListView");
        Shell.Current.GoToAsync(nameof(MyListView));
    }
}
