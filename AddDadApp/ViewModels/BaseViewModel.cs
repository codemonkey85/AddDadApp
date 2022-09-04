namespace AddDadApp.ViewModels;

[ObservableObject]
public partial class BaseViewModel
{
    public Action<string, string, string> DisplayAlert;

    public async Task Speak(string text) => await TextToSpeech.Default.SpeakAsync(text);
}
