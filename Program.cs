using System;
using System.Collections.Generic;
using System.Linq;

namespace OopBasics
{
    class Program
    {
        static void Main(string[] args)
        {
                    
            bool status = true;       
            List<Animal> animals = new List<Animal>();

            while (status) 
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("\n1. Add an animal");
                Console.WriteLine("2. Print every animal species");
                Console.WriteLine("3. Delete every animal species that starts with a vowel");
                Console.WriteLine("4. Exit");
                Console.Write("\nType your option: ");
                int option = Int32.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                        Console.Write("\nName: ");
                        var name = Console.ReadLine();

                        Console.Write("Species: ");
                        var species = Console.ReadLine();

                        Console.Write("Age: ");
                        var age = Int32.Parse(Console.ReadLine());

                        Console.Write("Gender (F/M): ");
                        var gender = Console.ReadLine();

                        Console.Write("Weight in kg: ");
                        var weight = Int32.Parse(Console.ReadLine());

                        var anAnimal = new Animal(name, species, age, gender, weight);
                        animals.Add(anAnimal);    
                        break;
                    case 2:
                        Console.WriteLine("\nPrinting animals species...\n");
                        animals.ForEach(animal => Console.WriteLine($"{animal.species}")); 
                        break;
                    case 3:
                        Console.Write("\nType a vowel: ");
                        char vowel = Char.Parse(Console.ReadLine());
                        char upperVowel = Char.ToUpper(vowel);
                        char lowerVowel = Char.ToLower(vowel);
                        Console.WriteLine($"\nDeleting animals that starts with {upperVowel} or {lowerVowel}...");
                        for(int i = 0; i < animals.Count; i++)
                        {
                            animals.RemoveAll(animal => 
                            {
                                if (animal.species.StartsWith(upperVowel))
                                    return true;
                                else if (animal.species.StartsWith(lowerVowel))
                                    return true;
                                else
                                    return false;                    
                            });
                        }  
                        break;
                    case 4: status = false; Console.WriteLine("The program has ended");
                        break;
                    default: Console.WriteLine("That option doesn't exist");
                        break;
                }
            }
        }
    }
}