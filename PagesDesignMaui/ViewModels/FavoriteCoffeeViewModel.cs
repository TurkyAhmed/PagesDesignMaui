using PagesDesignMaui.Models;
using System.Collections.ObjectModel;

namespace PagesDesignMaui.ViewModels
{
    public class FavoriteCoffeeViewModel
    {
        public List<Coffee> FavoriteCoffees { get; set; }

        public ObservableCollection<CoffeePair> CoffeePairs { get; set; }

        public FavoriteCoffeeViewModel()
        {
            FavoriteCoffees = new List<Models.Coffee>
            {
                new Coffee { Id = 1, Name = "Espresso", Description = "Strong and bold coffee", ImageUrl = "coffee.jpg", Price = 2.50m, Category = "Espresso", Rating = 4.5m },
                new Coffee { Id = 2, Name = "Latte", Description = "Creamy coffee with milk", ImageUrl = "coffee.jpg", Price = 3.00m, Category = "Latte", Rating = 4.0m },
                new Coffee { Id = 3, Name = "Cappuccino", Description = "Rich coffee with frothy milk", ImageUrl = "coffee.jpg", Price = 3.50m, Category = "Cappuccino", Rating = 4.2m },
                new Coffee { Id = 4, Name = "Ice Latte", Description = "Rich coffee with frothy milk", ImageUrl = "coffee.jpg", Price = 3.50m, Category = "Cappuccino", Rating = 4.2m }
            };
            CoffeePairs = new ObservableCollection<CoffeePair>();

            AddCoffeePair();
        }

        public void AddCoffeePair()
        {
            if ( FavoriteCoffees.Count() > 0 )
            {
                for (int i = 0; i < FavoriteCoffees.Count(); i+= 2)
                {
                    CoffeePair pair = new CoffeePair
                    {
                        Coffee1 = FavoriteCoffees[i],
                        Coffee2 = i + 1 < FavoriteCoffees.Count ? FavoriteCoffees[i + 1] : null
                    };

                    CoffeePairs.Add(pair);
                }
            }
        }

    }
}
