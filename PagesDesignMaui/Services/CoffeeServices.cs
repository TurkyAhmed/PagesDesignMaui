using PagesDesignMaui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagesDesignMaui.Services
{
    public class CoffeeServices
    {
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
				Price = "$3.00",
                Category = "Espresso",
                Rating = "4.5"
            },
            new Coffee
            {
                Id = 2,
                Name = "Latte",
                Description = "A creamy coffee made with espresso and steamed milk, topped with a light layer of foam.",
                ImageUrl = "coffee.jpg",
				//ImageUrl = "latte.jpg",
				Price = "$4.00",
                Category = "Milk Coffee",
                Rating = "4.7"
            },
            new Coffee
            {
                Id = 3,
                Name = "Cappuccino",
                Description = "A rich coffee made with equal parts espresso, steamed milk, and frothed milk.",
				//ImageUrl = "cappuccino.jpg",
				ImageUrl = "coffee.jpg",
                Price = "$4.50",
                Category = "Milk Coffee",
                Rating = "4.6"
            }
        };

            return coffees.ToList();
        }
    }
}
