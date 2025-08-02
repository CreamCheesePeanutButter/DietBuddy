using System;
namespace DietBuddy
{
	public class UserInformation
	{
        // Properties to store user information
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        // Constructor to initialize user information
        public UserInformation(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

    };
};

