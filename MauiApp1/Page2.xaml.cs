

namespace MauiApp1;

public partial class Page2 : ContentPage
{
    
	public Page2()
	{
		InitializeComponent();
	}

    private async void BotonPage2_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page3());
    }
}