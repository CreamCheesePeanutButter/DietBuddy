using System;
namespace DietBuddy
{
    public class Dish
    {
        // Properties to store dish information
        public string DishName { get; set; }
        public string Ingredients { get; set; }
        private int Calories = CalculateCalories();
        // Constructor to initialize dish information
        public Dish(string dishName, string ingredients, int calories)
        {
            DishName = dishName;
            Ingredients = ingredients;
            Calories = calories;
        }
        // Method to display dish information
        private double CalculateCalories()
        {
            return 1000;
        }
        public void DisplayDishInfo()
        {
            Console.WriteLine($"Dish Name: {DishName}");
            Console.WriteLine($"Ingredients: {Ingredients}");
            Console.WriteLine($"Calories: {Calories}");
        }
    }
}
