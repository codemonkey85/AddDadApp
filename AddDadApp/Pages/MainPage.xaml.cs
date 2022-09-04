namespace AddDadApp.Pages;

public partial class MainPage : ContentPage
{
    private readonly MainPageViewModel viewModel;

    public MainPage(MainPageViewModel viewModel)
    {
        InitializeComponent();
        viewModel.DisplayAlert += async (string title, string message, string cancel) => await DisplayAlert(title, message, cancel);
        BindingContext = this.viewModel = viewModel;
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs e)
    {
        base.OnNavigatedTo(e);
        if (viewModel.People.Count == 0)
        {
            viewModel.LoadDataCommand.Execute(null);
        }
    }
}
