

namespace MauiApp1;

public partial class Page4 : ContentPage
{
	public Page4()
	{
        InitializeComponent();
	}

    private async void BotonPage4_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NewPage1());
    }
}