namespace AddDadApp.Pages;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageViewModel viewModel)
    {
        InitializeComponent();
        viewModel.DisplayAlert += async () =>
        {
            await DisplayAlert("Title", "Message", "OK");
        };
        BindingContext = viewModel;
    }
}
