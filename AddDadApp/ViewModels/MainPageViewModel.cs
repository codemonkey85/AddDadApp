namespace AddDadApp.ViewModels;

public partial class MainPageViewModel : BaseViewModel
{
    [RelayCommand]
    private void ClickDad() => DisplayAlert?.Invoke("Title", "Message", "Cancel");
}
