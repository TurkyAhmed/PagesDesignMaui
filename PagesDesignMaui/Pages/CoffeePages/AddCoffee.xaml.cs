using PagesDesignMaui.ViewModels;

namespace PagesDesignMaui.Pages.CoffeePages;

public partial class AddCoffee : ContentPage
{
	public AddCoffee()
	{
		InitializeComponent();

		// To Make Binding
		this.BindingContext = new CoffeeViewModel();

    }
}