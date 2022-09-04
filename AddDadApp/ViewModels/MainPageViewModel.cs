namespace AddDadApp.ViewModels;

public partial class MainPageViewModel : BaseViewModel
{
    public ObservableCollection<Person> People = new()
    {
        new("Dad"),
        new("Mom"),
        new("Caleb"),
        new("Ethan"),
    };
}
