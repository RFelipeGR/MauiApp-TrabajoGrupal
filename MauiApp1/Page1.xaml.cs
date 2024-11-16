
namespace MauiApp1;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    private async void BotonPage1_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page2());

    }
}