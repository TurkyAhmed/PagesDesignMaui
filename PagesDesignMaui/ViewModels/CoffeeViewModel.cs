using PagesDesignMaui.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace PagesDesignMaui.ViewModels
{
    public class CoffeeViewModel : INotifyPropertyChanged
    {
        #region Property Change
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region Backing Fields
        private string name;
        private string description;
        private string imageUrl;
        private decimal price;
        private string category;
        private decimal rating;
        #endregion

        #region Properties
        public string Name 
        { 
            get => name;
            set 
            { 
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged(nameof(Name));
                }
            } 
        }

        public string Description 
        { 
            get => description; 
            set 
            { 
                if (description != value)
                {
                    description = value;
                    OnPropertyChanged(nameof(Description));
                }
            }
        }

        public string ImageUrl 
        { 
            get => imageUrl; 
            set 
            { 
                if (imageUrl != value)
                {
                    imageUrl = value;
                    OnPropertyChanged(nameof(ImageUrl));
                }
            }
        }

        public decimal Price 
        { 
            get => price; 
            set 
            { 
                if (price != value)
                {
                    price = value;
                    OnPropertyChanged(nameof(Price));
                }
            }
        }

        public string Category 
        { 
            get => category; 
            set 
            { 
                if (category != value)
                {
                    category = value;
                    OnPropertyChanged(nameof(Category));
                }
            }
        }

        public decimal Rating 
        { 
            get => rating; 
            set 
            { 
                if (rating != value)
                {
                    rating = value;
                    OnPropertyChanged(nameof(Rating));
                }
            }
        }

        public ObservableCollection<Coffee> CoffeeCollection { get; set; }

        #endregion

        public CoffeeViewModel()
        {
            CoffeeCollection = new ObservableCollection<Coffee>
            {
                new Coffee
                {
                    Id = 1,
                    Name = "Espresso",
                    Description = "A strong and bold coffee made by forcing hot water through finely-ground coffee beans.",
                    ImageUrl = "coffee.jpg",
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
                    Price = 4.00m,
                    Category = "Milk Coffee",
                    Rating = 4.7m
                },
                new Coffee
                {
                    Id = 3,
                    Name = "Cappuccino",
                    Description = "A rich coffee made with equal parts espresso, steamed milk, and frothed milk.",
                    ImageUrl = "coffee.jpg",
                    Price = 4.50m,
                    Category = "Milk Coffee",
                    Rating = 4.6m
                }
            };
        }



    }
}
