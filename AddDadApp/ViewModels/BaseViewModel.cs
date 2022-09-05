namespace AddDadApp.ViewModels;

[ObservableObject]
public partial class BaseViewModel
{
    [ObservableProperty]
    private string title;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotBusy))]
    private bool isBusy;

    public bool IsNotBusy => !IsBusy;

    public Action<string, string, string> DisplayAlert;

    public static async Task Speak(string text) => await TextToSpeech.Default.SpeakAsync(text);
}
