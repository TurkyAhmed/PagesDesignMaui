using PagesDesignMaui.Pages;
using PagesDesignMaui.Pages.CoffeePages;

namespace PagesDesignMaui
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void Coffee_Clicked(object sender, EventArgs e)
        {
             Navigation.PushModalAsync(new CoffeePage());
        }
    }
}
