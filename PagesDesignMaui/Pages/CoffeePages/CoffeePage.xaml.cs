using PagesDesignMaui.Models;
using PagesDesignMaui.Services;

namespace PagesDesignMaui.Pages.CoffeePages;

public partial class CoffeePage : ContentPage
{
    
	public CoffeePage()
	{
		InitializeComponent();

		var coffeeList = GetAllCoffee();

        //tabViewCoffee.ItemsSource = coffeeList;

        coffeeListView.ItemsSource = coffeeList;

        this.BindingContext = this;
        
    }

    public List<Coffee> GetAllCoffee()
    {
        List<Coffee> coffees = new List<Coffee>
    {
        new Coffee 
        {
            Id = 1,
            Name = "Espresso",
            Description = "A strong and bold coffee made by forcing hot water through finely-ground coffee beans.",
            ImageUrl = "coffee.jpg",
			//ImageUrl = "espresso.jpg",
			Price = 3.00m,
            Category = "Espresso",
            Rating = 4.5m
        },
        new Coffee
        {
            Id = 2,
            Name = "Latte",
            Description = "A creamy coffee made with espresso and steamed milk, topped with a light layer of foam.",
            ImageUrl = "coffee.jpg",
			//ImageUrl = "latte.jpg",
			Price = 4.00m,
            Category = "Milk Coffee",
            Rating = 4.7m
        },
        new Coffee
        {
            Id = 3,
            Name = "Cappuccino",
            Description = "A rich coffee made with equal parts espresso, steamed milk, and frothed milk.",
			//ImageUrl = "cappuccino.jpg",
			ImageUrl = "coffee.jpg",
            Price = 4.5m,
            Category = "Milk Coffee",
            Rating = 4.0m
        }
    };

        return coffees.ToList();
    }

}