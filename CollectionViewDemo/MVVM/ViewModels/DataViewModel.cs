using System.Collections.ObjectModel;
using CollectionViewDemo.MVVM.Models;

namespace CollectionViewDemo.MVVM.ViewModels;

public class DataViewModel
{
    public ObservableCollection<Product> Products { get; set; }

    public DataViewModel()
    {
        Products = new ObservableCollection<Product>
        {
            new Product
            {
                Name = "Yogurt",
                Price = 60.0m,
                Image = "yogurt.jpg",
                HasOffer = false,
                Stock = 10
            },
            new Product
            {
                Name = "Milk",
                Price = 30.0m,
                Image = "milk.jpg",
                HasOffer = true,
                OfferPrice = 25.0m,
                Stock = 5
            },
            new Product
            {
                Name = "Cheese",
                Price = 80.0m,
                Image = "cheese.jpg",
                HasOffer = false,
                Stock = 3
            },
            new Product
            {
                Name = "Butter",
                Price = 50.0m,
                Image = "butter.jpg",
                HasOffer = true,
                OfferPrice = 45.0m,
                Stock = 7
            },
            new Product
            {
                Name = "Eggs",
                Price = 40.0m,
                Image = "eggs.jpg",
                HasOffer = false,
                Stock = 15
            },
            new Product
            {
                Name = "Bread",
                Price = 20.0m,
                Image = "bread.jpg",
                HasOffer = true,
                OfferPrice = 15.0m,
                Stock = 2
            },
            new Product
            {
                Name = "Apple",
                Price = 10.0m,
                Image = "apple.jpg",
                HasOffer = false,
                Stock = 20
            },
            new Product
            {
                Name = "Banana",
                Price = 5.0m,
                Image = "banana.jpg",
                HasOffer = true,
                OfferPrice = 3.0m,
                Stock = 30
            },
            new Product
            {
                Name = "Orange",
                Price = 8.0m,
                Image = "orange.jpg",
                HasOffer = false,
                Stock = 25
            },
            new Product
            {
                Name = "Grapes",
                Price = 15.0m,
                Image = "grapes.jpg",
                HasOffer = true,
                OfferPrice = 12.0m,
                Stock = 10
            }   
        };
    }
}
