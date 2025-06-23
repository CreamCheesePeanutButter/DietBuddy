using System;
using System.IO;

namespace DietBuddy
{
    public class DishCenter
    {
        // Properties to store dish information
        private IList<Dish> dishLibrary;

        // Constructor to initialize dish information
        public State state { get; }
        public DishCenter(string dishName, string ingredients, int calories)
        {
            State state = State.Input;
            dishLibrary = LoadAvailableDish();
        }
        //Load available dishes from csv file 
        private List<Dish> LoadAvailableDish()
        {
            List<Dish> dishLibrary = new List<Dish>();
            StreamReader fileStream = new StreamReader("Dishes.txt");
            string line;

            while ((line = fileStream.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 3)
                {
                    string dishName = parts[0].Trim();
                    string ingredients = parts[1].Trim();
                    if (int.TryParse(parts[2].Trim(), out int calories))
                    {
                        Dish dish = new Dish(dishName, ingredients, calories);
                        dishLibrary.Add(dish);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid calorie value for dish: {dishName}");
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid line format: {line}");
                }
            }
            fileStream.Close();
            return dishLibrary;
        }
        public void ChooseDish()
        {
            Random rand = new Random();
            int randomIndex = rand.Next(dishLibrary.Count);
            Dish selectedDish = dishLibrary[randomIndex];
        }
        public void ChooseDish(string name, string ingredients)
        {
            Dish newDish = new Dish(name, ingredients, 1000);
            dishLibrary.Add(newDish);
        }
      
    }
}