namespace AddDadApp.ViewModels;

public partial class MainPageViewModel : BaseViewModel
{
    [ObservableProperty]
    private ObservableCollection<Person> people = new();

    [ObservableProperty]
    private bool isRefreshing;

    public MainPageViewModel() => Title = "People";

    [RelayCommand]
    private async Task LoadDataAsync()
    {
        if (IsBusy)
        {
            return;
        }
        try
        {
            People.Clear();
            IsBusy = true;
            using var file = await FileSystem.OpenAppPackageFileAsync("people.json");
            var people = JsonSerializer.Deserialize<Person[]>(file);
            foreach (var person in people)
            {
                People.Add(person);
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
        }
        finally
        {
            IsBusy = false;
            IsRefreshing = false;
        }
    }

    [RelayCommand]
    private static async Task SpeakName(Person person)
    {
        HapticFeedback.Default.Perform(HapticFeedbackType.Click);
        if (person is { Name.Length: > 0 })
        {
            await Speak(person.Name);
        }
    }
}
