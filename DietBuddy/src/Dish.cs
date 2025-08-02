using System;
namespace DietBuddy
{
    public class Dish
    {
        // Properties to store dish information
        public string DishName { get; set; }
        public string Ingredients { get; set; }
        private double Calories { get; set; }
        private string Recipe { get; set; }
        // Constructor to initialize dish information
        public Dish(string dishName, string ingredients, int calories, string recipe = "Recipe not available")
        {
            DishName = dishName;
            Ingredients = ingredients;
            Calories = CalculateCalories();
            Recipe = recipe; // Placeholder for recipe information
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
        public string getName()
        {
            return DishName;
        }
        public string getIngredients()
        {
            return Ingredients;
        }
        public string getCalories()
        {
            return Calories.ToString();
        }
        public string getRecipe()
        {
            return Recipe;
        }
    }
}
