namespace AddDadApp.Models;

public class Person
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("imagePath")]
    public string ImagePath { get; set; }
}

public class PeopleRoot
{
    [JsonPropertyName("people")]
    public List<Person> People { get; set; }
}
