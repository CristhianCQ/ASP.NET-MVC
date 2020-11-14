using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {

        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant {Id =1, Name = "Cristhian's Pizza", Cuisine = CuisineType.Italian },
                new Restaurant {Id =2, Name = "Tersaiguels", Cuisine = CuisineType.Frech},
                new Restaurant {Id =3 , Name = "Taj mah", Cuisine = CuisineType.Indian},
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(x => x.Name ); 
        }
    }
}
