using System;

namespace DietBuddy
{
    public class DishCenter
    {
        // Properties to store dish information
        private IList<Dish> dishLibrary = new List<Dish>();
                        
        // Constructor to initialize dish information
        public DishCenter(string dishName, string ingredients, int calories)
        {
            DishName = dishName;
            Ingredients = ingredients;
            Calories = calories;
            State state = new State.Input;
        }
        // Method to display dish information
        public void DisplayDishInfo()
        {
            Console.WriteLine($"Dish Name: {DishName}");
            Console.WriteLine($"Ingredients: {Ingredients}");
            Console.WriteLine($"Calories: {Calories}");
        }
    }
}