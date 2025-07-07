using PagesDesignMaui.Models;
using PagesDesignMaui.Services;

namespace PagesDesignMaui.Pages.CoffeePages;

public partial class CoffeePage : ContentPage
{
    private readonly CoffeeServices _coffeeServices;
	public CoffeePage( CoffeeServices coffeeServices)
	{
		InitializeComponent();

        _coffeeServices = coffeeServices;

		var coffeeList = GetAllCoffee();

        //tabViewCoffee.ItemsSource = coffeeList;

        coffeeListView.ItemsSource = coffeeList;


        this.BindingContext = this;
        
    }

    public IList<Coffee> GetAllCoffee() =>_coffeeServices.GetAllCoffee();


}