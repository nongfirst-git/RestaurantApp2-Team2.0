using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Restaurant> restaurants = new List<Restaurant> 
            {

            new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
            new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
            new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7),
            new Restaurant(4, "Huguosi Snacks", "Snacks", 5.0),
            new Restaurant(5, "Haidilao Hot Pot", "hot pot", 4.7)

            };
            Console.WriteLine("=== Add New Restaurant ===");

            Console.Write("Enter Restaurant Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Restaurant Type: ");
            string type = Console.ReadLine();

            Console.Write("Enter Restaurant Rating: ");
            double rating = Convert.ToDouble(Console.ReadLine());

            // Generate new ID
            int id = restaurants.Count + 1;

            // Add restaurant to List
            restaurants.Add(new Restaurant(id, name, type, rating));

            Console.WriteLine("Restaurant added successfully!");
            Console.WriteLine();

            foreach (var item in restaurants)
            {
                Console.WriteLine(
                    $"{item.Id} {item.Name}. ({item.Type}) - Rating: {item.Rating}");
            }
            var amount = restaurants.Count();
            var avg = restaurants.Average(x => x.Rating);
            Console.WriteLine($"Total is {amount}");
            Console.WriteLine($"Score Average is {avg}");
            Console.WriteLine("End");

        }
    }
    class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Rating { get; set; }

        public Restaurant (int id, string name, string type, double rating)
        {
            Id = id;
            Name = name;
            Type = type;
            Rating = rating;
          
        }
    }
}
