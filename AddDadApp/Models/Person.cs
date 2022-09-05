namespace AddDadApp.Models;

[ObservableObject]
public partial class Person
{
    private string name;
    private string imagePath;

    [JsonPropertyName("name")]
    public string Name
    {
        get => name;
        set => SetProperty(ref name, value);
    }

    [JsonPropertyName("imagePath")]
    public string ImagePath
    {
        get => imagePath;
        set => SetProperty(ref imagePath, value);
    }
}
