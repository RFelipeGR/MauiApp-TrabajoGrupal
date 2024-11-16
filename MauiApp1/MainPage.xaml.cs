namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void BotonPrueba_Clicked(object sender, EventArgs e)
        {
            count=count+3;
            Label1.Text = "La suma es " + count;
            
        }

        private async void BotonNavegacion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewPage1());
        }
    }

}
