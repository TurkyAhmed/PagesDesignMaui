using PagesDesignMaui.Models;
using PagesDesignMaui.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

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
        private Coffee selectedCoffee;
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

        public Coffee SelectedCoffee 
        { 
            get => selectedCoffee; 
            set 
            { 
                if (selectedCoffee != value)
                {
                    selectedCoffee = value;

                    Name = selectedCoffee.Name;
                    Description = selectedCoffee.Description;
                    ImageUrl = selectedCoffee.ImageUrl ?? string.Empty;
                    Price = value?.Price ?? 0.0m;
                    Category = selectedCoffee.Category ?? string.Empty;
                    Rating = value?.Rating ?? 0.0m;

                    OnPropertyChanged(nameof(SelectedCoffee));
                }
            }
        }

        public ObservableCollection<Coffee> CoffeeCollection { get; set; }

        #endregion

        #region Command Properties
        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        #endregion

        private readonly ICoffeeServices _coffeeService;

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

            //LoadData();

            AddCommand = new Command(AddCoffee);

            EditCommand = new Command(UpdateCoffee);

            DeleteCommand = new Command(DeleteCoffee);


        }

        //public async void LoadData()
        //{
        //    CoffeeCollection.Clear();

        //    var coffeeList = _coffeeService.GetAllCoffee();
        //    foreach (var coffee in coffeeList)
        //    {
        //        CoffeeCollection.Add(coffee);
        //    }
        //}


        private void DeleteCoffee(object obj)
        {
            throw new NotImplementedException();
        }

        private void UpdateCoffee(object obj)
        {
            throw new NotImplementedException();
        }

        private void AddCoffee(object obj)
        {
            var newId = CoffeeCollection.Count() > 0 ? CoffeeCollection.Max(n => n.Id + 1) : 1;

            var coffee = new Coffee
            {
                Id = newId,
                Name = Name,
                Description = Description,
                ImageUrl = "coffee.jpg",
                Price = Price,
                Category = Category,
                Rating = Rating
            };

            CoffeeCollection.Add(coffee);

            ClearData();
        }

        public void ClearData()
        {
            Name = Description = ImageUrl = Category = string.Empty;

            Price = Rating = 0.0m;
        }
    }
}
