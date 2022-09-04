namespace AddDadApp.ViewModels;

[ObservableObject]
public partial class MainPageViewModel
{
    public Action DisplayAlert;

    [RelayCommand]
    private void ClickDad()
    {
        DisplayAlert?.Invoke();
    }
}
