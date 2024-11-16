

namespace MauiApp1;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
	}
    
    private async void OnImageTapped(object sender, EventArgs e)
    {
       
        await Navigation.PushAsync(new Page4());
    }

}