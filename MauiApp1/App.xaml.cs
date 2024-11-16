/*namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}*/
using MauiApp1;

namespace MauiApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Usamos NavigationPage para que se pueda navegar entre páginas
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
