namespace AddDadApp.Pages;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageViewModel viewModel)
    {
        InitializeComponent();
        viewModel.DisplayAlert += async (string title, string message, string cancel) => await DisplayAlert(title, message, cancel);
        BindingContext = viewModel;
        PeopleCollection.ItemsSource = viewModel.People;
    }
}
