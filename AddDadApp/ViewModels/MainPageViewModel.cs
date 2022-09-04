namespace AddDadApp.ViewModels;

public partial class MainPageViewModel : BaseViewModel
{
    [ObservableProperty]
    private ObservableCollection<Person> people = new();

    [RelayCommand]
    private async Task LoadDataAsync()
    {
        try
        {
            People.Clear();
            using var file = await FileSystem.OpenAppPackageFileAsync("people.json");
            var peopleRoot = JsonSerializer.Deserialize<PeopleRoot>(file);
            foreach (var person in peopleRoot.People)
            {
                People.Add(person);
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
        }
    }

    [RelayCommand]
    private async Task SpeakName(Person person)
    {
        if (person is { Name.Length: > 0 })
        {
            await Speak(person.Name);
        }
    }
}
