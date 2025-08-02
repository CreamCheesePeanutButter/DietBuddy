using System;
using System.Diagnostics;
using System.IO;

namespace DietBuddy
{
    public class DishCenter
    {
        // Properties to store dish information
        private IList<Dish> dishLibrary;

        // Constructor to initialize dish information
        public State state { get; }
        public DishCenter()
        {
            State state = State.Input;
            dishLibrary = LoadAvailableDish();
        }
        //Load available dishes from csv file 
        private List<Dish> LoadAvailableDish()
        {
            List<Dish> dishLibrary = new List<Dish>();
            using (StreamReader fileStream = new StreamReader("C:\\Users\\cream\\OneDrive\\Documents\\GitHub\\DietBuddy\\DietBuddy\\src\\dishes.csv"))
            {
                string line;

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                while ((line = fileStream.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 4)
                    {
                        Trace.WriteLine($"Processing line: {line}");
                        string dishName = parts[0].Trim();
                        string ingredients = parts[1].Trim();
                        if (int.TryParse(parts[2].Trim(), out int calories))
                        {
                            string recipe = parts[3].Trim();
                            // Assuming Dish is a class with a constructor that accepts these parameters
                            dishLibrary.Add(new Dish(dishName, ingredients, calories, recipe));
                        }
                        else
                        {
                            Trace.WriteLine($"Invalid calorie value: {parts[2]}");
                        }
                    }
                    else
                    {
                        Trace.WriteLine($"Invalid line format: {line}");
                    }
                }
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                fileStream.Close();
            }

            return dishLibrary;
        }
        public Dish ChooseDish()
        {
            Random rand = new Random();
            Dish selectedDish;
            if (dishLibrary.Count == 0)Trace.WriteLine("library is zeor");
            int randomIndex = rand.Next(0, dishLibrary.Count - 1);
            selectedDish = dishLibrary[randomIndex];
            Trace.WriteLine($"Try this dish: {selectedDish.getName()}");
            return selectedDish;
        }
           
    }
}