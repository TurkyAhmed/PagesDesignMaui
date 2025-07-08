using PagesDesignMaui.Pages.CoffeePages;

namespace PagesDesignMaui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            //return new Window(new AddCoffee());
            return new Window(new FavoriteCoffee());
        }
    }
}