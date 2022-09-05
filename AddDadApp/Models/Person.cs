namespace AddDadApp.Models;

public record Person([property: JsonPropertyName("name")] string Name, [property: JsonPropertyName("imagePath")] string ImagePath);
