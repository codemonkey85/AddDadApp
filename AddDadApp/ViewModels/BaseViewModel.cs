namespace AddDadApp.ViewModels;

[ObservableObject]
public partial class BaseViewModel
{
    public Action<string, string, string> DisplayAlert;
}
