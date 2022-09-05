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
