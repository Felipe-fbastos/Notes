namespace Notes;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();

	}
    private async void AboutButtonF_Clicked(object sender, EventArgs e)
    {
		await Launcher.Default.OpenAsync("https://github.com/Felipe-fbastos"); //Linka para um página na WEB
    }

    private async void AboutButtonP_Clicked(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://github.com/Pedro-Ruan");
    }
}