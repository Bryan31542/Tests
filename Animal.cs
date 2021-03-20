using System;
using System.Collections.Generic;

namespace OopBasics
{
    class Animal
    {
        // Attributes
        string? name; 
        string gender;
        int age;
        double weight;

        public string species { get; set; }

        // Builder
        public Animal(string name, string species, int age, string gender, double weight)
        {
            this.name = name;
            this.species = species;
            this.age = age;
            this.gender = gender;
            this.weight = weight;
        }

        // Methods
        public void Awake(string awakeTime)
        {
            Console.WriteLine($"The {name} is waking up at {awakeTime}");
        }

        public void Eat(string food)
        {
            Console.WriteLine($"The {name} is eating {food}");
        }

        public void Sleep(string sleepTime)
        {
            Console.WriteLine($"The {name} is going to sleep at {sleepTime}");
        }
    }
}
