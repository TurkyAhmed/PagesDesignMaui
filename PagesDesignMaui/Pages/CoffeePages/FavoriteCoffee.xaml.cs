using PagesDesignMaui.ViewModels;

namespace PagesDesignMaui.Pages.CoffeePages;

public partial class FavoriteCoffee : ContentPage
{
	public FavoriteCoffee()
	{
		InitializeComponent();

		BindingContext = new FavoriteCoffeeViewModel();
    }
}